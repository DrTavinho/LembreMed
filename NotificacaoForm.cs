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
    public partial class NotificacaoForm : Form
    {
        private Medication _medicamento;
        private TimeSpan _horario;

        public NotificacaoForm(Medication med, TimeSpan horario)
        {
            InitializeComponent();
            _medicamento = med;
            _horario = horario;

            groupBox1.Text = "Hora de tomar seu medicamento!";
            label1.Text = med.Name + " - " + med.Dose;
            label2.Text = $"Horário: {horario:hh\\:mm}";
        }

        public event Action<HistoryEntry> OnRegistrarHistorico;
        private void btnTomei_Click(object sender, EventArgs e)
        {
            var entry = new HistoryEntry
            {
                MedicationId = _medicamento.Id,
                MedicationName = _medicamento.Name,
                Dose = _medicamento.Dose,
                ScheduledTime = DateTime.Today.Add(_horario),
                ActualTime = DateTime.Now,
                Action = "Tomei"
            };

            OnRegistrarHistorico?.Invoke(entry);
            this.Close();
        }

        private void btnNaoTomei_Click(object sender, EventArgs e)
        {
            var entry = new HistoryEntry
            {
                MedicationId = _medicamento.Id,
                MedicationName = _medicamento.Name,
                Dose = _medicamento.Dose,
                ScheduledTime = DateTime.Today.Add(_horario),
                ActualTime = DateTime.Now,
                Action = "Ignorei"
            };

            OnRegistrarHistorico?.Invoke(entry);
            this.Close();
        }

        public event Action<Medication, DateTime> OnAdiar;
        private void btnLembrarDepois_Click(object sender, EventArgs e)
        {
            // Adiar por 1 minuto (seria 10, mas para testes/apresentação mudei pra 1)
            DateTime novaDataHora = DateTime.Now.AddMinutes(1);

            OnAdiar?.Invoke(_medicamento, novaDataHora);

            this.Close();
        }
    }
}
