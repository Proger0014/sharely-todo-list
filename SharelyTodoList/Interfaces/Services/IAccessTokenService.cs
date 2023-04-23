using SharelyTodoList.Models.AccessToken;

namespace SharelyTodoList.Interfaces.Services;

public interface IAccessTokenService
{
    // string - это токен входа
    Task<string> CreateAccessToken(long id);
    Task RemoveAccessToken(string accessToken);
}