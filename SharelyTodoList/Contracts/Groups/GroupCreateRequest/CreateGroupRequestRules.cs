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
            .MaximumLength(150)
            .WithMessage(ValidationErrorUtils.GetMessageFrom(ValidationErrorType.MaximumLength, "Name", 150));
    }
}