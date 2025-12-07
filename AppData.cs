using LembreMed;
using System.Collections.Generic;

public class AppData
{
    public List<HistoryEntry> History { get; set; } = new();
    public List<Medication> Medications { get; set; } = new List<Medication>();
    public List<DoseRecord> DoseRecords { get; set; } = new List<DoseRecord>();
}
