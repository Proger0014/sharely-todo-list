namespace SharelyTodoList.Models;

public class GroupModel
{
    public const int NameMaxLength = 150;
    public const int PasswordMaxLength = 50;
    
    public long Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}