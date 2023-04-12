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

    public TaskGroup GetById(long id)
    {
        return _taskGroupRepository.GetById(id);
    }

    public long CreateTaskGroup(string name, string password)
    {
        TaskGroup newTaskGroup = new TaskGroup()
        {
            Name = name,
            Password = password
        };

        return _taskGroupRepository.Create(newTaskGroup);
    }
}
