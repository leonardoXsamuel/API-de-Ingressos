namespace IngressosAPI.model;

public class Event
{
    public long EventId { get; set; }
    public string EventName { get; set; }
    public string Theme { get; set; }
    public int Capacity { get; set; }
    public int OccupiedSpots { get; set; }
}