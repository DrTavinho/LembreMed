using System;
using System.Collections.Generic;

public class Medication
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public string Name { get; set; }         // Ex: "Losartana"
    public string Dose { get; set; }         // Ex: "50 mg"

    // Lista de horários (08:00, 20:00 etc.)
    public List<TimeSpan> Times { get; set; } = new List<TimeSpan>();

    public string Notes { get; set; } = "";  // Observações
    public bool Active { get; set; } = true; // Se deve emitir notificações

    public DateTime? NextNotification { get; set; } // Para função snooze

    // Construtor vazio (necessário para serialização JSON)
    public Medication()
    {
    }
}
