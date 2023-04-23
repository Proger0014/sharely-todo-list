using SharelyTodoList.Models.AccessToken;

namespace SharelyTodoList.Interfaces.Repositories;

public interface IAccessTokenRepository
{
    Task Insert(AccessToken accessToken);
    Task<AccessToken?> GetByToken(string token);
    Task RemoveByToken(string token);
}