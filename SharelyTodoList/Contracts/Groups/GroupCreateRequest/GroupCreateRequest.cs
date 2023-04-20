namespace SharelyTodoList.Contracts.Groups.GroupCreateRequest;

public class GroupCreateRequest
{
    public string Name { get; set; }
    public string Password { get; set; }

    public GroupCreateRequest()
    {
        Name = string.Empty;
        Password = string.Empty;
    }
}
