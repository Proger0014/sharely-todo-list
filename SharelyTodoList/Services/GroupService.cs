using SharelyTodoList.Constants;
using SharelyTodoList.Exceptions;
using SharelyTodoList.Interfaces.Services;
using SharelyTodoList.Models.Group;
using SharelyTodoList.Repositories;

namespace SharelyTodoList.Services;

public class GroupService : IGroupService
{
    private readonly GroupRepository _groupRepository;

    public GroupService(GroupRepository groupRepository)
    {
        _groupRepository = groupRepository;
    }

    public Group GetById(long id)
    {
        var existsGroup =  _groupRepository.GetById(id);

        if (existsGroup is null)
        {
            throw new EntityNotFoundException(string.Format(
                ExceptionMessages.GROUP_NOT_FOUND, nameof(Group), id));
        }

        return existsGroup;
    }

    public long CreateGroup(string name, string password)
    {
        Group newGroup = new Group()
        {
            Name = name,
            Password = password
        };

        return _groupRepository.Create(newGroup);
    }
}
