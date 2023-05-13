using SharelyTodoList.Models;
using SharelyTodoList.Entities.Group;

namespace SharelyTodoList.Interfaces.Repositories;

public interface IGroupRepository
{
    Task<GroupModel?> GetById(long groupId);
    Task<long> Create(GroupModel newGroup);
}