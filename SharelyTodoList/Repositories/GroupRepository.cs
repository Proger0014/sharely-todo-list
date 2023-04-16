using Microsoft.EntityFrameworkCore;
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
        return await _dbContext.TaskGroups?
            .AsNoTracking()
            .SingleOrDefaultAsync(tgs => tgs.Id == groupId)!;
    }

    /// <returns>Возвращает id только что добавленного в бд group</returns>
    public async Task<long> Create(Group newGroup)
    {
        _dbContext.TaskGroups?
            .Add(newGroup);
        await _dbContext.SaveChangesAsync();

        return newGroup.Id;
    }
}
