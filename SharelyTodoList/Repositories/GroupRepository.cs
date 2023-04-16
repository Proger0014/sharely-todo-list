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

    public Group? GetById(long groupId)
    {
        return _dbContext.TaskGroups?
            .AsNoTracking()
            .SingleOrDefault(tgs => tgs.Id == groupId);
    }

    /// <returns>Возвращает id только что добавленного в бд group</returns>
    public long Create(Group newGroup)
    {
        _dbContext.TaskGroups?
            .Add(newGroup);
        _dbContext.SaveChanges();

        return newGroup.Id;
    }
}
