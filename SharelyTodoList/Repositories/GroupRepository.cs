using Microsoft.EntityFrameworkCore;
using SharelyTodoList.Constants;
using SharelyTodoList.Exceptions;
using SharelyTodoList.Interfaces.Repositories;
using SharelyTodoList.Models.Group;

namespace SharelyTodoList.Repositories;

public class GroupRepository : IGroupRepository
{
    private readonly AppDbContext _dbContext;

    public GroupRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Group?> GetById(long groupId)
    {
        return await _dbContext.Groups?
            .AsNoTracking()
            .SingleOrDefaultAsync(tgs => tgs.Id == groupId)!;
    }

    /// <returns>Возвращает id только что добавленного в бд group</returns>
    public async Task<long> Create(Group newGroup)
    {
        _dbContext.Groups?
            .Add(newGroup);
        await _dbContext.SaveChangesAsync();

        return newGroup.Id;
    }

    public async Task<bool> IsValidPassword(long groupId, string password)
    {
        Group? existsGroup = await GetById(groupId);

        if (existsGroup is null)
        {
            throw new NotFoundException(string.Format(
                ExceptionMessages.EntityNotFound, nameof(Group), groupId));
        }
        
        existsGroup = await _dbContext.Groups.AsNoTracking()
            .Where(group => group.Id == groupId && group.Password == password)
            .FirstOrDefaultAsync();

        return existsGroup is not null;
    }
}
