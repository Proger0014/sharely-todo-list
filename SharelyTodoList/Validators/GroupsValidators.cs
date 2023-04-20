using SharelyTodoList.Contracts.Groups.GroupCreateRequest;
using SharelyTodoList.Contracts.IdQueryParameter;
using SharelyTodoList.Models.Group;

namespace SharelyTodoList.Validators;

public class GroupsValidators : BaseValidators<Group>
{
    public GroupsValidators()
    {
        Dictionary<Type, object> validators = new()
        {
            { typeof(GroupCreateRequest), new GroupCreateRequestRules() },
            { typeof(IdQueryParameterRequest), new IdQueryParameterRequestRules() }
        };

        Validators = validators;
    }
}