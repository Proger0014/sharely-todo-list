using FluentValidation;
using SharelyTodoList.Utils;

namespace SharelyTodoList.Contracts.Groups.GetByIdPreviewRequest;

public class GetByIdPreviewRequestRules : AbstractValidator<GetByIdPreviewRequest>
{
    public GetByIdPreviewRequestRules()
    {
        RuleFor(target => target.GroupId)
            .GreaterThanOrEqualTo(0)
            .WithMessage(ValidationErrorUtils
                .GetMessageFrom(ValidationErrorType.GreaterThanOrEqualTo, "GroupId"));
    }
}