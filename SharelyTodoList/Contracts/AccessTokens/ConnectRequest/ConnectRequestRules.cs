using FluentValidation;
using SharelyTodoList.Constants;
using SharelyTodoList.Utils;

namespace SharelyTodoList.Contracts.AccessTokens.ConnectRequest;

public class ConnectRequestRules : AbstractValidator<ConnectRequest>
{
    public ConnectRequestRules()
    {
        const string groupId = nameof(ConnectRequest.GroupId);
        const string password = nameof(ConnectRequest.Password);
        
        RuleFor(target => target.GroupId)
            .GreaterThanOrEqualTo(BaseModelConstants.MinIdValue)
            .WithMessage(ValidationErrorUtils
                .GetMessageFrom(ValidationErrorType.GreaterThanOrEqualTo, groupId, BaseModelConstants.MinIdValue));

        RuleFor(target => target.Password)
            .NotEmpty()
            .WithMessage(ValidationErrorUtils
                .GetMessageFrom(ValidationErrorType.NotEmpty, password));
    }
}