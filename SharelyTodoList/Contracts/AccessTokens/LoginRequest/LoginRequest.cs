namespace SharelyTodoList.Contracts.AccessTokens.LoginRequest;

public class LoginRequest
{
    public long GroupId { get; set; }
    public string Password { get; set; } = string.Empty;
}