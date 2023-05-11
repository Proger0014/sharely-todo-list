using Microsoft.EntityFrameworkCore;
using SharelyTodoList.Entities.AccessToken;
using SharelyTodoList.Extensions;
using SharelyTodoList.Interfaces.Repositories;
using SharelyTodoList.Models;

namespace SharelyTodoList.Repositories;

public class AccessTokenRepository : IAccessTokenRepository
{
    private readonly AppDbContext _dbContext;
    
    public AccessTokenRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task Insert(AccessTokenModel accessToken)
    {
        _dbContext.AccessTokens?.Add(accessToken.MapToEntity()!);
        await _dbContext.SaveChangesAsync();
    }

    public async Task<AccessTokenModel?> GetByToken(string token)
    {
        var accessToken = await _dbContext.AccessTokens?
            .AsNoTracking()
            .SingleOrDefaultAsync(at => at.Token == token)!;
        
        return accessToken!.MapToModel();
    }

    public async Task RemoveByToken(string token)
    {
        AccessTokenModel? forDeletedModel = await GetByToken(token);

        _dbContext?.AccessTokens?.Remove(forDeletedModel.MapToEntity()!);
    }
}