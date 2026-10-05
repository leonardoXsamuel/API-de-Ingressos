using AutoMapper;
using IngressosAPI.DTOs.EventDTOs;
using IngressosAPI.model;
using IngressosAPI.Repositories;
using IngressosAPI.Services.Interfaces;
using System.Runtime.CompilerServices;

namespace IngressosAPI.Services;

public class EventService : IEventService
{
    private readonly EventRepository _repository;
    private readonly IMapper _mapper;

    public EventService(EventRepository repository, Mapper mapper)
    {
        _mapper = mapper;
        _repository = repository;
    }

    public async Task<EventResponseDTO> GetEventAsyncById(long id)
    {
        //throw new NotImplementedException();

        var @event =  await _repository.GetEventByIdAsync(id);
        var responseDTO = _mapper.Map<EventResponseDTO>(@event);

        return responseDTO;
    }
}
