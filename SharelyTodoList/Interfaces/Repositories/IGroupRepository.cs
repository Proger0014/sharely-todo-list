using SharelyTodoList.Models.Group;

namespace SharelyTodoList.Interfaces.Repositories;

public interface IGroupRepository
{
    Group? GetById(long groupId);
    long Create(Group newGroup);
}