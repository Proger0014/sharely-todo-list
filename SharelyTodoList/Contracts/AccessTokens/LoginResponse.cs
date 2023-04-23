namespace SharelyTodoList.Contracts.AccessTokens;

public class LoginResponse
{
    public string AccessToken { get; set; }

    public LoginResponse()
    {
        AccessToken = string.Empty;
    }
}