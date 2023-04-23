using SharelyTodoList.Models.Group;

namespace SharelyTodoList.Interfaces.Repositories;

public interface IGroupRepository
{
    Task<Group?> GetById(long groupId);
    Task<long> Create(Group newGroup);
    Task<bool> IsValidPassword(long groupId, string password);
}