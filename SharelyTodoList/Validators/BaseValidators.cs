using FluentValidation;
using FluentValidation.Results;

namespace SharelyTodoList.Validators;

public abstract class BaseValidators<TSource>
    where TSource : class
{
    protected Dictionary<Type, object>? Validators { get; init; }

    public async Task<ValidationResult> Validate<T>(T target)
        where T : class
    {
        return await ((IValidator<T>)Validators![typeof(T)]).ValidateAsync(target);
    }
}