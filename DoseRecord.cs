using System;

public class DoseRecord
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid MedicationId { get; set; }

    public DateTime ScheduledAt { get; set; }   // horário programado
    public DateTime? TakenAt { get; set; }      // null = não tomou

    public bool Confirmed => TakenAt.HasValue;
}
