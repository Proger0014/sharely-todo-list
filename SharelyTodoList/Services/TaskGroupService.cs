using SharelyTodoList.Models.TaskGroup;
using SharelyTodoList.Repositories;

namespace SharelyTodoList.Services;

public class TaskGroupService
{
    private readonly TaskGroupRepository _taskGroupRepository;

    public TaskGroupService(TaskGroupRepository taskGroupRepository)
    {
        _taskGroupRepository = taskGroupRepository;
    }

    public Group GetById(long id)
    {
        return _taskGroupRepository.GetById(id);
    }

    public long CreateTaskGroup(string name, string password)
    {
        Group newGroup = new Group()
        {
            Name = name,
            Password = password
        };

        return _taskGroupRepository.Create(newGroup);
    }
}
