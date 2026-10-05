using IngressosAPI.DTOs.EventDTOs;
using IngressosAPI.model;

namespace IngressosAPI.Services.Interfaces;

public interface IEventService
{
    public Task<EventResponseDTO> GetEventAsyncById(long id);
    public Task<EventResponseDTO> CreateEvent(EventCreateDTO dto);


}
