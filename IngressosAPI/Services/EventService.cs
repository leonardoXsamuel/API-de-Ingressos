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

    public async Task<EventResponseDTO> CreateEvent(EventCreateDTO dto)
    {
        var @event = _mapper.Map<Event>(dto);
        var responseDTO = await _repository.CreateEvent(@event);

        return _mapper.Map<EventResponseDTO>(responseDTO);
    }

    public async Task<EventResponseDTO> GetEventAsyncById(long id)
    {
        //throw new NotImplementedException();

        var @event = await _repository.GetEventByIdAsync(id);
        var responseDTO = _mapper.Map<EventResponseDTO>(@event);

        return responseDTO;
    }
}
