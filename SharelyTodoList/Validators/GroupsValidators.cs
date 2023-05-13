using SharelyTodoList.Contracts.Groups.GetByIdPreviewRequest;
using SharelyTodoList.Contracts.Groups.GroupCreateRequest;
using SharelyTodoList.Models;

namespace SharelyTodoList.Validators;

public class GroupsValidators : BaseValidators<GroupModel>
{
    public GroupsValidators()
    {
        Validators = new()
        {
            { typeof(CreateGroupRequest), new CreateGroupRequestRules() },
            { typeof(GetByIdPreviewRequest), new GetByIdPreviewRequestRules() }
        };
    }
}