using IngressosAPI.Model.Enum;
using System.Net.Sockets;

namespace IngressosAPI.model;

public class Ticket
{
    public long TicketId { get; set; }
    public int TicketBatch { get; set; } // ->  lote: 1
    public required decimal TicketPrice { get; set; }
    public TicketStatus TicketStatus { get; set; }

    public User User { get; set; }

    public long EventId { get; set; }
    public Event Event { get; set; }   
}
