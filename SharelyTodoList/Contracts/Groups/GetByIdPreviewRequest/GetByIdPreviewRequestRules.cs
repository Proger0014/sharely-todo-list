using FluentValidation;
using SharelyTodoList.Constants;
using SharelyTodoList.Utils;

namespace SharelyTodoList.Contracts.Groups.GetByIdPreviewRequest;

public class GetByIdPreviewRequestRules : AbstractValidator<GetByIdPreviewRequest>
{
    public GetByIdPreviewRequestRules()
    {
        const string groupId = nameof(GetByIdPreviewRequest.GroupId);
        
        RuleFor(target => target.GroupId)
            .GreaterThanOrEqualTo(BaseModelConstants.MinIdValue)
            .WithMessage(ValidationErrorUtils
                .GetMessageFrom(ValidationErrorType.GreaterThanOrEqualTo, groupId, BaseModelConstants.MinIdValue));
    }
}