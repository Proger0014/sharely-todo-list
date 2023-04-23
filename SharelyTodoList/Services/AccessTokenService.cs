using SharelyTodoList.Interfaces.Repositories;
using SharelyTodoList.Interfaces.Services;
using SharelyTodoList.Models.AccessToken;

namespace SharelyTodoList.Services;

public class AccessTokenService : IAccessTokenService
{
    private readonly IAccessTokenRepository _accessTokenRepository;

    public AccessTokenService(IAccessTokenRepository accessTokenRepository)
    {
        _accessTokenRepository = accessTokenRepository;
    }
    
    public async Task<string> CreateAccessToken(long id)
    {
        string newToken = Guid.NewGuid().ToString();

        await _accessTokenRepository.Insert(new AccessToken()
        {
            Token = newToken,
            GroupId = id
        });

        return newToken;
    }

    public async Task RemoveAccessToken(string accessToken)
    {
        await _accessTokenRepository.RemoveByToken(accessToken);
    }
}