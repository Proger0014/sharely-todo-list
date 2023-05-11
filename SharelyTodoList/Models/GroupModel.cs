namespace SharelyTodoList.Models;

public class GroupModel
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string Password { get; set; }

    public GroupModel()
    {
        Name = string.Empty;
        Password = string.Empty;
    }
}