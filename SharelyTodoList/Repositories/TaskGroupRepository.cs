using SharelyTodoList.Models.Group;

namespace SharelyTodoList.Repositories;

public class TaskGroupRepository
{
    private readonly AppDbContext _dbContext;

    public TaskGroupRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Group? GetById(long id)
    {
        return _dbContext.TaskGroups
            .SingleOrDefault(tgs => tgs.Id == id);
    }

    /// <returns>Возвращает id только что добавленного в бд task group</returns>
    public long Create(Group group)
    {
        _dbContext.TaskGroups.Add(group);
        _dbContext.SaveChanges();

        return group.Id;
    }
}
