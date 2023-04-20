using FluentValidation;
using SharelyTodoList.Utils;

namespace SharelyTodoList.Contracts.Groups.GroupCreateRequest;

public class GroupCreateRequestRules : AbstractValidator<GroupCreateRequest>
{
    public GroupCreateRequestRules()
    {
        RuleFor(g => g.Name)
            .NotNull()
            .WithMessage(ValidationErrorUtils.GetMessageFrom(ValidationErrorType.NotNull, "Name"))
            .Length(10)
            .WithMessage(ValidationErrorUtils.GetMessageFrom(ValidationErrorType.MaximumLength, "Name", 150));
    }
}