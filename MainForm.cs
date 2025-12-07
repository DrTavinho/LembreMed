using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LembreMed
{
    public partial class MainForm : Form
    {
        private JsonRepository repository;
        private AppData appData;

        public MainForm()
        {
            InitializeComponent();

            repository = new JsonRepository("data.json");
            appData = repository.Load();

            ConfigurarColunasHistorico();
            ConfigurarColunasMedicamentos();
            AtualizarGrid();

            foreach (DataGridViewColumn col in dgvMedicamentos.Columns)
            {
                Console.WriteLine("\n!!!!!!!!!!!!!!!!!!!!!!!! -> " + col.Name);
            }
        }

        private void AtualizarGrid()
        {
            if (mostrandoHistorico)
                AtualizarGridHistorico();
            else
                AtualizarGridMedicamentos();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var form = new CadastroForm())
            {
                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    appData.Medications.Add(form.MedicamentoResultado);
                    repository.Save(appData);
                    AtualizarGrid();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMedicamentos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um medicamento para excluir.");
                return;
            }

            Guid id = (Guid)dgvMedicamentos.SelectedRows[0].Cells["Id"].Value;

            var med = appData.Medications.FirstOrDefault(m => m.Id == id);

            if (med == null)
                return;

            if (MessageBox.Show($"Excluir '{med.Name}'?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                appData.Medications.Remove(med);
                repository.Save(appData);
                AtualizarGrid();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvMedicamentos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um medicamento para editar.");
                return;
            }

            // pegar ID da linha selecionada
            Guid id = (Guid)dgvMedicamentos.SelectedRows[0].Cells["Id"].Value;

            var med = appData.Medications.FirstOrDefault(m => m.Id == id);

            if (med == null)
                return;

            var form = new CadastroForm(med);

            if (form.ShowDialog() == DialogResult.OK)
            {
                repository.Save(appData);
                AtualizarGrid();
            }
        }

        private HashSet<string> notificacoesHoje = new HashSet<string>();
        private void timer_Tick(object sender, EventArgs e)
        {
            DateTime agora = DateTime.Now;

            // Verificar snooze primeiro
            foreach (var med in appData.Medications.Where(m => m.Active))
            {
                if (med.NextNotification.HasValue &&
                    agora >= med.NextNotification.Value)
                {
                    // dispara o popup
                    MostrarPopupNotificacao(med, med.NextNotification.Value.TimeOfDay);

                    // limpa o snooze
                    med.NextNotification = null;
                    repository.Save(appData);
                }
            }

            // Verificar horários regulares
            foreach (var med in appData.Medications.Where(m => m.Active))
            {
                foreach (var horario in med.Times)
                {
                    // Chave única para evitar notificações repetidas no mesmo dia
                    string chave = $"{med.Id}_{horario}_{agora:ddMMyyyy}";

                    // tolerância leve de 1 minuto para evitar erro do timer
                    var horarioHoje = DateTime.Today.Add(horario);
                    double diferencaMinutos = Math.Abs((horarioHoje - agora).TotalMinutes);

                    if (!notificacoesHoje.Contains(chave) &&
                        diferencaMinutos <= 1)
                    {
                        MostrarPopupNotificacao(med, horario);
                        notificacoesHoje.Add(chave);
                    }
                }
            }

            // Reset diário
            if (agora.Hour == 0 && agora.Minute == 0)
                notificacoesHoje.Clear();
        }

        private void MostrarPopupNotificacao(Medication med, TimeSpan horario)
        {
            System.Media.SystemSounds.Exclamation.Play();
            var popup = new NotificacaoForm(med, horario)
            {
                TopMost = true
            };

            popup.OnAdiar += (m, novaDataHora) =>
            {
                // salvar snooze absoluto
                m.NextNotification = novaDataHora;

                repository.Save(appData);
                AtualizarGrid();
            };

            popup.OnRegistrarHistorico += (entry) =>
            {
                appData.History.Add(entry);
                repository.Save(appData);
            };

            popup.Show();
        }

        private bool mostrandoHistorico = false;
        private void btnToggleView_Click(object sender, EventArgs e)
        {
            mostrandoHistorico = !mostrandoHistorico;

            if (mostrandoHistorico)
            {
                btnToggleView.Text = "Mostrar Medicamentos";
                AtualizarGridHistorico();
                btnAdd.Enabled = false;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                btnToggleView.Text = "Mostrar Histórico";
                AtualizarGridMedicamentos();
                btnAdd.Enabled = true;
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void AtualizarGridMedicamentos()
        {
            dgvMedicamentos.Columns.Clear();
            ConfigurarColunasMedicamentos();

            var lista = appData.Medications
                .Select(m => new
                {
                    m.Id,
                    m.Name,
                    m.Dose,
                    TimesDisplay = string.Join(", ", m.Times.Select(t => t.ToString(@"hh\:mm"))),
                    m.Notes,
                    m.Active
                })
                .ToList();

            dgvMedicamentos.DataSource = lista;

            if (dgvMedicamentos.Columns.Contains("Id"))
                dgvMedicamentos.Columns["Id"].Visible = false;

        }

        private void ConfigurarColunasMedicamentos()
        {
            dgvMedicamentos.AutoGenerateColumns = false;
            dgvMedicamentos.Columns.Clear();

            dgvMedicamentos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Id",
                HeaderText = "Id",
                DataPropertyName = "Id",
                Visible = false
            });

            dgvMedicamentos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Nome",
                HeaderText = "Nome",
                DataPropertyName = "Name",
                Width = 150
            });

            dgvMedicamentos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Dose",
                HeaderText = "Dose",
                DataPropertyName = "Dose",
                Width = 80
            });

            dgvMedicamentos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Horarios",
                HeaderText = "Horários",
                DataPropertyName = "TimesDisplay",
                Width = 200
            });

            dgvMedicamentos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Notas",
                HeaderText = "Notas",
                DataPropertyName = "Notes",
                Width = 300
            });

            dgvMedicamentos.Columns.Add(new DataGridViewCheckBoxColumn
            {
                Name = "Ativo",
                HeaderText = "Ativo",
                DataPropertyName = "Active",
                Width = 50
            });
        }

        private void AtualizarGridHistorico()
        {
            dgvMedicamentos.Columns.Clear();
            ConfigurarColunasHistorico();

            dgvMedicamentos.DataSource = appData.History
                .OrderByDescending(h => h.ActualTime)
                .Select(h => new
                {
                    Nome = h.MedicationName,
                    Dose = h.Dose,
                    Agendado = h.ScheduledTime.ToString("HH:mm"),
                    Tomado = h.ActualTime.ToString("HH:mm:ss"),
                    Data = h.ActualTime.ToString("dd/MM/yyyy"),
                    Ação = h.Action
                })
                .ToList();
        }

        private void ConfigurarColunasHistorico()
        {
            dgvMedicamentos.AutoGenerateColumns = false;

            dgvMedicamentos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Medicamento",
                HeaderText = "Medicamento",
                DataPropertyName = "Nome",
                Width = 150
            });

            dgvMedicamentos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Dose",
                HeaderText = "Dose",
                DataPropertyName = "Dose",
                Width = 80
            });

            dgvMedicamentos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Agendado",
                HeaderText = "Horário Agendado",
                DataPropertyName = "Agendado",
                Width = 150
            });

            dgvMedicamentos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Tomado",
                HeaderText = "Horário Real",
                DataPropertyName = "Tomado",
                Width = 120
            });

            dgvMedicamentos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Data",
                HeaderText = "Data",
                DataPropertyName = "Data",
                Width = 100
            });

            dgvMedicamentos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Ação",
                HeaderText = "Ação",
                DataPropertyName = "Ação",
                Width = 120
            });
        }

        private void btnResetAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Isso irá APAGAR TODOS os dados:\n\n" +
                "- Medicamentos\n" +
                "- Horários\n" +
                "- Snoozes (NextNotification)\n" +
                "- Histórico\n\n" +
                "Deseja continuar?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) != DialogResult.Yes)
            {
                return;
            }

            // Zerar tudo
            appData.Medications.Clear();
            appData.History.Clear();

            // Se os objetos tiverem NextNotification
            foreach (var med in appData.Medications)
                med.NextNotification = null;

            // Salvar no JSON
            repository.Save(appData);

            // Atualizar o grid
            AtualizarGrid();

            MessageBox.Show("Todos os dados foram apagados com sucesso!");
        }
    }
}
