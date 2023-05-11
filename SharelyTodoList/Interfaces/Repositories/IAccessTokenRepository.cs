using SharelyTodoList.Models;
using SharelyTodoList.Entities.AccessToken;

namespace SharelyTodoList.Interfaces.Repositories;

public interface IAccessTokenRepository
{
    Task Insert(AccessTokenModel accessToken);
    Task<AccessTokenModel?> GetByToken(string token);
    Task RemoveByToken(string token);
}