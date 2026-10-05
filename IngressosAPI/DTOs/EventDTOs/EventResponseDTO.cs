using IngressosAPI.model;
using IngressosAPI.Model.Enum;
namespace IngressosAPI.DTOs.EventDTOs;

public class EventResponseDTO
{
    public string EventName { get; set; }
    public string Theme { get; set; }
    public int Capacity { get; set; }
    public int OccupiedSpots { get; set; }
}
