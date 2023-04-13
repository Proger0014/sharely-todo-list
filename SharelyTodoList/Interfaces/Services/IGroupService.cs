using SharelyTodoList.Models.Group;

namespace SharelyTodoList.Interfaces.Services;

public interface IGroupService
{
    Group GetById(long id);
    long CreateGroup(string name, string password);
}