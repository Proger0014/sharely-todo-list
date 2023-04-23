using Microsoft.EntityFrameworkCore;
using SharelyTodoList.Interfaces.Repositories;
using SharelyTodoList.Models.AccessToken;

namespace SharelyTodoList.Repositories;

public class AccessTokenRepository : IAccessTokenRepository
{
    private readonly AppDbContext _dbContext;
    
    public AccessTokenRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task Insert(AccessToken accessToken)
    {
        _dbContext.AccessTokens?.Add(accessToken);
        await _dbContext.SaveChangesAsync();
    }

    public async Task<AccessToken?> GetByToken(string token)
    {
        return await _dbContext.AccessTokens?
            .AsNoTracking()
            .SingleOrDefaultAsync(at => at.Token == token)!;
    }

    public async Task RemoveByToken(string token)
    {
        AccessToken forDeleted = await GetByToken(token);

        _dbContext?.AccessTokens?.Remove(forDeleted!);
    }
}