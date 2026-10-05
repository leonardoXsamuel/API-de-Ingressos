using IngressosAPI.Model.Enum;

namespace IngressosAPI.model;

public class User
{
    public long UserId { get; set; }
    public required string Username { get; set; }
    public required string Login { get; set; }
    public required string PasswordHash { get; set; }
    public Status Status { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
