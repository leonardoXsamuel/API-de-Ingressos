using IngressosAPI.DTOs.UserDTOs;

namespace IngressosAPI.Services.Interfaces;

public interface IUserService
{
    public Task<UserResponseDTO> GetUserAsync(long Id);
    public Task<UserResponseDTO> PostUser(UserCreateDTO dto);
}
