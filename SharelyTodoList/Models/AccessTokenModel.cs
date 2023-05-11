namespace SharelyTodoList.Models;

public class AccessTokenModel
{
    public string Token { get; set; }
    public long GroupId { get; set; }

    public AccessTokenModel()
    {
        Token = string.Empty;
    }
}