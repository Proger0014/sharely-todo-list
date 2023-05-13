namespace SharelyTodoList.Contracts.AccessTokens.ConnectRequest;

public class ConnectRequest
{
    public long GroupId { get; set; }
    public string Password { get; set; } = string.Empty;
}