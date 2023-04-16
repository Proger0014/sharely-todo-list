using SharelyTodoList.Models.Group;

namespace SharelyTodoList.Interfaces.Services;

public interface IGroupService
{
    Group GetById(long groupId);
    long CreateGroup(string name, string password);
}