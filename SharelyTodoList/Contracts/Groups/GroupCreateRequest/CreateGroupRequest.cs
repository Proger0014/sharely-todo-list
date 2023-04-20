namespace SharelyTodoList.Contracts.Groups.GroupCreateRequest;

public class CreateGroupRequest
{
    public string Name { get; set; }
    public string Password { get; set; }

    public CreateGroupRequest()
    {
        Name = string.Empty;
        Password = string.Empty;
    }
}
