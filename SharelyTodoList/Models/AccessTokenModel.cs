namespace SharelyTodoList.Models;

public class AccessTokenModel
{
    public const int TokenMaxLength = 150;

    public string Token { get; set; } = string.Empty;
    public long GroupId { get; set; }
}