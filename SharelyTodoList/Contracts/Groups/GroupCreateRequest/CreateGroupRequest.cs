namespace SharelyTodoList.Contracts.Groups.GroupCreateRequest;

public class CreateGroupRequest
{
    public string Name { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}
