using AutoMapper;
using IngressosAPI.DTOs.TicketDTOs;
using IngressosAPI.model;

namespace IngressosAPI.Profiles;

public class TicketProfile : Profile
{
    public TicketProfile()
    {
        CreateMap<Ticket, TicketResponseDTO>().ReverseMap();
        CreateMap<Ticket, TicketCreateDTO>().ReverseMap();
        CreateMap<Ticket, TicketUpdateDTO>().ReverseMap();
    }
}