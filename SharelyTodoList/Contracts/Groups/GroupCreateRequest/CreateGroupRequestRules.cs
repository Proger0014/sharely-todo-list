using FluentValidation;
using SharelyTodoList.Utils;

namespace SharelyTodoList.Contracts.Groups.GroupCreateRequest;

public class CreateGroupRequestRules : AbstractValidator<CreateGroupRequest>
{
    public CreateGroupRequestRules()
    {
        RuleFor(target => target.Name)
            .NotNull()
            .WithMessage(ValidationErrorUtils.GetMessageFrom(ValidationErrorType.NotNull, "Name"))
            .Length(10)
            .WithMessage(ValidationErrorUtils.GetMessageFrom(ValidationErrorType.MaximumLength, "Name", 150));
    }
}