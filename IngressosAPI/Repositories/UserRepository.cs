using IngressosAPI.AppDbContext;
using IngressosAPI.DTOs.UserDTOs;
using IngressosAPI.model;
using Microsoft.EntityFrameworkCore;

namespace IngressosAPI.Repositories;

public class UserRepository
{
    private readonly ApplicationDbContext _dbContext;

    public UserRepository(ApplicationDbContext appDbContext)
    {
        _dbContext = appDbContext;
    }
        
    // create methods
    public async Task<User> GetUserByIdAsync(long Id)
    {
        User user = await _dbContext.Users.FindAsync(Id);
        return user;
    }
    
    public async Task<User> PostUser (User user)
    {
        await _dbContext.Users.AddAsync(user);
        await _dbContext.SaveChangesAsync();
     
        return await _dbContext.Users.FindAsync(user.UserId);
    }

}
