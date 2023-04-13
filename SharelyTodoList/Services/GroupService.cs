using SharelyTodoList.Models.Group;
using SharelyTodoList.Repositories;

namespace SharelyTodoList.Services;

public class GroupService
{
    private readonly GroupRepository _groupRepository;

    public GroupService(GroupRepository groupRepository)
    {
        _groupRepository = groupRepository;
    }

    public Group GetById(long id)
    {
        return _groupRepository.GetById(id);
    }

    public long CreateTaskGroup(string name, string password)
    {
        Group newGroup = new Group()
        {
            Name = name,
            Password = password
        };

        return _groupRepository.Create(newGroup);
    }
}
