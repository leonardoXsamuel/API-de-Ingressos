using AutoMapper;
using IngressosAPI.DTOs.EventDTOs;
using IngressosAPI.model;

namespace IngressosAPI.Profiles;

public class EventProfile : Profile
{
    public EventProfile()
    {
        CreateMap<Event, EventResponseDTO>().ReverseMap();
        CreateMap<Event, EventCreateDTO>().ReverseMap();
        CreateMap<Event, EventUpdateDTO>().ReverseMap();
    }
}