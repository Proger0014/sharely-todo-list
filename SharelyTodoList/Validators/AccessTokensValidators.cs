using SharelyTodoList.Contracts.AccessTokens.LoginRequest;
using SharelyTodoList.Models;

namespace SharelyTodoList.Validators;

public class AccessTokensValidators : BaseValidators<AccessTokenModel>
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