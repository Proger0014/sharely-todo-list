using SharelyTodoList.Constants;
using SharelyTodoList.Exceptions;
using SharelyTodoList.Interfaces.Repositories;
using SharelyTodoList.Interfaces.Services;
using SharelyTodoList.Models.Group;

namespace SharelyTodoList.Services;

public class GroupService : IGroupService
{
    private readonly IGroupRepository _groupRepository;

    public GroupService(IGroupRepository groupRepository)
    {
        _groupRepository = groupRepository;
    }

    public Group GetById(long groupId)
    {
        var existsGroup =  _groupRepository.GetById(groupId);

        if (existsGroup is null)
        {
            throw new EntityNotFoundException(string.Format(
                ExceptionMessages.GROUP_NOT_FOUND, nameof(Group), groupId));
        }

        return existsGroup;
    }

    public long CreateGroup(string name, string password)
    {
        var newGroup = new Group()
        {
            Name = name,
            Password = password
        };

        return _groupRepository.Create(newGroup);
    }
}
