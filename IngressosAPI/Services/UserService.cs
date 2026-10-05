using AutoMapper;
using IngressosAPI.DTOs.UserDTOs;
using IngressosAPI.model;
using IngressosAPI.Repositories;
using IngressosAPI.Services.Interfaces;

namespace IngressosAPI.Services;

public class UserService : IUserService
{
    private readonly IMapper _mapper;
    private readonly UserRepository _repository;

    public UserService(UserRepository repository, IMapper mapper)
    {
        _mapper = mapper;
        _repository = repository;
    }

    public async Task<UserResponseDTO> GetUserAsync(long Id)
    {
        var response = await _repository.GetUserByIdAsync(Id);
        var responseDTO = _mapper.Map<UserResponseDTO>(response);

        return responseDTO;
    }

    public async Task<UserResponseDTO> PostUser(UserCreateDTO dto)
    {
        User user = _mapper.Map<User>(dto);
        var response = _mapper.Map<UserResponseDTO>(await _repository.PostUser(user));

        return response;
    }
}
