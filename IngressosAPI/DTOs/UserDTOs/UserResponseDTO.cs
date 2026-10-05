using IngressosAPI.Model.Enum;

namespace IngressosAPI.DTOs.UserDTOs;

public class UserResponseDTO
{
    public required string Username { get; set; }
    public Status Status { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
