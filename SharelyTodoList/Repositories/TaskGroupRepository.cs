using SharelyTodoList.Models.TaskGroup;

namespace SharelyTodoList.Repositories;

public class TaskGroupRepository
{
    private readonly AppDbContext _dbContext;

    public TaskGroupRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public TaskGroup? GetById(long id)
    {
        return _dbContext.TaskGroups
            .SingleOrDefault(tgs => tgs.Id == id);
    }

    /// <returns>Возвращает id только что добавленного в бд task group</returns>
    public long Create(TaskGroup taskGroup)
    {
        _dbContext.TaskGroups.Add(taskGroup);
        _dbContext.SaveChanges();

        return taskGroup.Id;
    }
}
