using SharelyTodoList.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using SharelyTodoList.Exceptions;
using SharelyTodoList.Constants;
using SharelyTodoList.Extensions;
using SharelyTodoList.Models;

namespace SharelyTodoList.Repositories;

public class GroupRepository : IGroupRepository
{
    private readonly AppDbContext _dbContext;

    public GroupRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<GroupModel?> GetById(long groupId)
    {
        var group = await _dbContext.Groups?
            .AsNoTracking()
            .SingleOrDefaultAsync(tgs => tgs.Id == groupId)!;

        return group!.MapToModel();
    }

    /// <returns>Возвращает id только что добавленного в бд group</returns>
    public async Task<long> Create(GroupModel newGroup)
    {
        var mappedNewGroup = newGroup.MapToEntity();
        
        _dbContext.Groups?
            .Add(mappedNewGroup!);
        await _dbContext.SaveChangesAsync();

        return mappedNewGroup!.Id;
    }

    // public async Task<bool> IsValidPassword(long groupId, string password)
    // {
    //     Group? existsGroup = await GetById(groupId);
    //
    //     if (existsGroup is null)
    //     {
    //         throw new NotFoundException(string.Format(
    //             ExceptionMessages.EntityNotFound, nameof(Group), groupId));
    //     }
    //     
    //     existsGroup = await _dbContext.Groups.AsNoTracking()
    //         .Where(group => group.Id == groupId && group.Password == password)
    //         .FirstOrDefaultAsync();
    //
    //     return existsGroup is not null;
    // }
}
