using FluentValidation;
using SharelyTodoList.Utils;

namespace SharelyTodoList.Contracts.IdQueryParameter;

public class IdQueryParameterRequestRules : AbstractValidator<IdQueryParameterRequest>
{
    public IdQueryParameterRequestRules()
    {
        RuleFor(iqp => iqp.Id)
            .GreaterThanOrEqualTo(0)
            .WithMessage(ValidationErrorUtils.GetMessageFrom(ValidationErrorType.GreaterThanOrEqualTo, "Id"));
    }
}