namespace SharelyTodoList.Entities.AccessToken;

public class AccessToken
{
    public string Token { get; set; }
    public long GroupId { get; set; }

    public AccessToken()
    {
        Token = string.Empty;
    }
}