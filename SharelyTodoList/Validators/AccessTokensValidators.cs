using SharelyTodoList.Contracts.AccessTokens.ConnectRequest;
using SharelyTodoList.Models;

namespace SharelyTodoList.Validators;

public class AccessTokensValidators : BaseValidators<AccessTokenModel>
{
    public AccessTokensValidators()
    {
        Validators = new()
        {
            { typeof(ConnectRequest), new ConnectRequestRules() }
        };
    }
}