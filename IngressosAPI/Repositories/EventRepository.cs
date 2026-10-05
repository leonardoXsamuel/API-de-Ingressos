using AutoMapper;
using IngressosAPI.AppDbContext;
using IngressosAPI.DTOs.EventDTOs;
using IngressosAPI.model;

namespace IngressosAPI.Repositories;

public class EventRepository
{
    private readonly ApplicationDbContext _dbContext;
    private readonly IMapper _mapper;

    public EventRepository(ApplicationDbContext appDbContext)
    {
        _dbContext = appDbContext;
    }

    // create methods
    public async Task<Event> GetEventByIdAsync(long Id)
    {
        return await _dbContext.Events.FindAsync(Id);
    }
    
    public async Task<Event> CreateEvent(Event @event)
    {
        var response = await _dbContext.Events.AddAsync(@event);
        await _dbContext.SaveChangesAsync();

        return @event;
    }

}
