using AutoMapper;
using IngressosAPI.DTOs.TicketDTOs;
using IngressosAPI.model;
using IngressosAPI.Repositories;
using IngressosAPI.Services.Interfaces;

namespace IngressosAPI.Services;

public class TicketService : ITicketService
{
    private readonly IMapper _mapper;
    private readonly TicketRepository _repository;

    public TicketService(TicketRepository repository, IMapper mapper)
    {
        _mapper = mapper;
        _repository = repository;
    }

    public async Task<TicketResponseDTO> BuyTicket(TicketCreateDTO ticketCreateDTO)
    {
        // add exceptions
        Ticket ticket = _mapper.Map<Ticket>(ticketCreateDTO);
        await _repository.BuyTicket(ticket);

        return _mapper.Map<TicketResponseDTO>(ticket);
    }


    public async Task<TicketResponseDTO> GetTicketAsyncById(long id)
    {
        //throw new NotImplementedException();
        Ticket ticket = await _repository.GetTicketByIdAsync(id);

        TicketResponseDTO responseDTO = _mapper.Map<TicketResponseDTO>(ticket);

        return responseDTO;
    }
}
