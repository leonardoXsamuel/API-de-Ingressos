using IngressosAPI.model;
using IngressosAPI.Model.Enum;

namespace IngressosAPI.DTOs.TicketDTOs;

public class TicketUpdateDTO
{
    public int TicketBatch { get; set; } // ->  lote: 1
    public required decimal TicketPrice { get; set; }
    public TicketStatus TicketStatus { get; set; }

    public User User { get; set; }

    public long EventId { get; set; }
    public Event Event { get; set; }
}
