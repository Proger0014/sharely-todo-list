using SharelyTodoList.Models.Group;

namespace SharelyTodoList.Interfaces.Repositories;

public interface IGroupRepository
{
    Group? GetById(long id);
    long Create(Group newGroup);
}