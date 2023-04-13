namespace SharelyTodoList.Models.Group;

public class Group
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string Password { get; set; }

    public Group()
    {
        Name = string.Empty;
        Password = string.Empty;
    }
}
