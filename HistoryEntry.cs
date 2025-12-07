using System;

namespace LembreMed
{
    public class HistoryEntry
    {
        public Guid MedicationId { get; set; }
        public string MedicationName { get; set; }
        public string Dose { get; set; }

        public DateTime ScheduledTime { get; set; }
        public DateTime ActualTime { get; set; }

        public string Action { get; set; } // "Tomei", "Ignorei", "Adiei"
    }
}
