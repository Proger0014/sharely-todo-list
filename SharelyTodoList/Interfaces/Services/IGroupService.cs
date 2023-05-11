using SharelyTodoList.Models;

namespace SharelyTodoList.Interfaces.Services;

public interface IGroupService
{
    Task<GroupModel> GetById(long groupId);
    Task<long> CreateGroup(string name, string password);
    Task<bool> IsValidPassword(long groupId, string password);
}