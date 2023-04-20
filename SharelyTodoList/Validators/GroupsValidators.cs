using SharelyTodoList.Contracts.Groups.GetByIdPreviewRequest;
using SharelyTodoList.Contracts.Groups.GroupCreateRequest;
using SharelyTodoList.Models.Group;

namespace SharelyTodoList.Validators;

public class GroupsValidators : BaseValidators<Group>
{
    public GroupsValidators()
    {
        Dictionary<Type, object> validators = new()
        {
            { typeof(CreateGroupRequest), new CreateGroupRequestRules() },
            { typeof(GetByIdPreviewRequest), new GetByIdPreviewRequestRules() }
        };

        Validators = validators;
    }
}