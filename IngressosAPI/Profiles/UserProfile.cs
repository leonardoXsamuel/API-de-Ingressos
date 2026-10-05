using AutoMapper;
using IngressosAPI.DTOs.UserDTOs;
using IngressosAPI.model;

namespace IngressosAPI.Profiles;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<User, TicketResponseDTO>().ReverseMap();
        CreateMap<User, UserCreateDTO>().ReverseMap();
        CreateMap<User, TicketUpdateDTO>().ReverseMap();
    }
}