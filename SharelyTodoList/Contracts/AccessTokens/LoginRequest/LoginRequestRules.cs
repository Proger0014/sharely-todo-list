using FluentValidation;
using SharelyTodoList.Constants;
using SharelyTodoList.Utils;

namespace SharelyTodoList.Contracts.AccessTokens.LoginRequest;

public class LoginRequestRules : AbstractValidator<LoginRequest>
{
    public LoginRequestRules()
    {
        const string groupId = nameof(LoginRequest.GroupId);
        const string password = nameof(LoginRequest.Password);
        
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