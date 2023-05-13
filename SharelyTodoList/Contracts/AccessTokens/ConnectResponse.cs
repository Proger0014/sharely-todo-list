namespace SharelyTodoList.Contracts.AccessTokens;

public class ConnectResponse
{
    public string AccessToken { get; set; }

    public ConnectResponse()
    {
        AccessToken = string.Empty;
    }
}