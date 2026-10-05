using AutoMapper;
using IngressosAPI.DTOs.TicketDTOs;
using IngressosAPI.model;

namespace IngressosAPI.Profiles;

public class TicketProfile : Profile
{
    public TicketProfile()
    {
        CreateMap<Ticket, EventResponseDTO>().ReverseMap();
        CreateMap<Ticket, EventCreateDTO>().ReverseMap();
        CreateMap<Ticket, EventUpdateDTO>().ReverseMap();
    }
}