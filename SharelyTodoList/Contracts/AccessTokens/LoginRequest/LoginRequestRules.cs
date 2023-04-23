using FluentValidation;
using SharelyTodoList.Utils;

namespace SharelyTodoList.Contracts.AccessTokens.LoginRequest;

public class LoginRequestRules : AbstractValidator<LoginRequest>
{
    public LoginRequestRules()
    {
        RuleFor(target => target.GroupId)
            .NotNull()
            .WithMessage(ValidationErrorUtils
                .GetMessageFrom(ValidationErrorType.NotNull, "GroupId"))
            .GreaterThanOrEqualTo(0)
            .WithMessage(ValidationErrorUtils
                .GetMessageFrom(ValidationErrorType.GreaterThanOrEqualTo, "GroupId"));

        RuleFor(target => target.Password)
            .NotNull()
            .WithMessage(ValidationErrorUtils
                .GetMessageFrom(ValidationErrorType.NotNull, "Password"));

        // RuleFor(target => target)
        //     .Must(target => )
        //     .WithMessage("");
    }
}