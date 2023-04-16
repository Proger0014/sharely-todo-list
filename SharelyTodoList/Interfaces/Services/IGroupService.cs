using SharelyTodoList.Models.Group;

namespace SharelyTodoList.Interfaces.Services;

public interface IGroupService
{
    Task<Group> GetById(long groupId);
    Task<long> CreateGroup(string name, string password);
}