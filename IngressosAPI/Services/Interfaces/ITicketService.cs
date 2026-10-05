using IngressosAPI.DTOs.TicketDTOs;
using IngressosAPI.model;

namespace IngressosAPI.Services.Interfaces;

public interface ITicketService
{
    public Task<TicketResponseDTO> BuyTicket(TicketCreateDTO ticketCreateDTO);
    public Task<TicketResponseDTO> GetTicketAsyncById(long id);
}
