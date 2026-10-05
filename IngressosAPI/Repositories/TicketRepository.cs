using IngressosAPI.AppDbContext;
using IngressosAPI.DTOs.UserDTOs;
using IngressosAPI.model;
using Microsoft.EntityFrameworkCore;

namespace IngressosAPI.Repositories;

public class TicketRepository
{
    private readonly ApplicationDbContext _dbContext;

    public TicketRepository(ApplicationDbContext appDbContext)
    {
        _dbContext = appDbContext;
    }
        
    // create methods
    public async Task<Ticket> GetTicketByIdAsync(long Id)
    {
        return await _dbContext.Tickets.FindAsync(Id);
    }
    
    public async Task<Ticket> BuyTicket (Ticket ticket)
    {
        await _dbContext.Tickets.AddAsync(ticket);
        await _dbContext.SaveChangesAsync();
     
        return await _dbContext.Tickets.FindAsync(ticket.TicketId);
    }

}
