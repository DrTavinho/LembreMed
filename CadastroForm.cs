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
    public partial class CadastroForm : Form
    {
        private Medication medicamento;   // null quando é cadastro novo
        private bool editMode = false;

        public Medication MedicamentoResultado { get; private set; }

        public CadastroForm()
        {
            InitializeComponent();
            chkAtivo.Checked = true; // padrão
        }

        public CadastroForm(Medication med)
        {
            InitializeComponent();
            this.medicamento = med;
            this.editMode = true;

            PreencherCampos();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void PreencherCampos()
        {
            txtNome.Text = medicamento.Name;
            txtDose.Text = medicamento.Dose;
            txtObservacoes.Text = medicamento.Notes;
            chkAtivo.Checked = medicamento.Active;

            lstHorarios.Items.Clear();

            foreach (var t in medicamento.Times)
                lstHorarios.Items.Add(t.ToString(@"hh\:mm"));
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("O nome do medicamento é obrigatório.");
                return false;
            }

            if (lstHorarios.Items.Count == 0)
            {
                MessageBox.Show("Adicione pelo menos um horário.");
                return false;
            }

            return true;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            // Converter horários
            var horarios = lstHorarios.Items
                .Cast<string>()
                .Select(h => TimeSpan.Parse(h))
                .ToList();

            if (editMode)
            {
                // Atualizar objeto existente
                medicamento.Name = txtNome.Text.Trim();
                medicamento.Dose = txtDose.Text.Trim();
                medicamento.Times = horarios;
                medicamento.Notes = txtObservacoes.Text.Trim();
                medicamento.Active = chkAtivo.Checked;

                MedicamentoResultado = medicamento;
            }
            else
            {
                // Criar novo objeto
                MedicamentoResultado = new Medication
                {
                    Name = txtNome.Text.Trim(),
                    Dose = txtDose.Text.Trim(),
                    Times = horarios,
                    Notes = txtObservacoes.Text.Trim(),
                    Active = chkAtivo.Checked
                };
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btnAdicionarHora_Click(object sender, EventArgs e)
        {
            string horario = dtpHorario.Value.ToString("HH:mm");

            // evita horários duplicados
            if (!lstHorarios.Items.Contains(horario))
                lstHorarios.Items.Add(horario);
        }

        private void btnRemoverHora_Click(object sender, EventArgs e)
        {
            if (lstHorarios.SelectedItem != null)
            {
                lstHorarios.Items.Remove(lstHorarios.SelectedItem);
            }
            else
            {
                MessageBox.Show("Selecione um horário para remover.");
            }
        }
    }
}
