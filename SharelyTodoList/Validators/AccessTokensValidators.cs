using SharelyTodoList.Contracts.AccessTokens.LoginRequest;
using SharelyTodoList.Models.AccessToken;

namespace SharelyTodoList.Validators;

public class AccessTokensValidators : BaseValidators<AccessToken>
{
    public AccessTokensValidators()
    {
        Dictionary<Type, object> validators = new()
        {
            { typeof(LoginRequest), new LoginRequestRules() }
        };

        Validators = validators;
    }
}