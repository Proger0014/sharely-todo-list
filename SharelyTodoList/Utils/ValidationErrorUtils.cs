using Microsoft.AspNetCore.Mvc.ModelBinding;
using SharelyTodoList.Constants;

namespace SharelyTodoList.Utils;

public static class ValidationErrorUtils
{
    public static string GetMessageFrom(
        ValidationErrorType errorType, params object[] arguments) => errorType switch
        {
            ValidationErrorType.NotNull => string.Format(ValidationErrorMessages.NotNullError, arguments),
            ValidationErrorType.GreaterThanOrEqualTo => string.Format(ValidationErrorMessages.GreaterThanOrEqualToError, arguments),
            ValidationErrorType.MaximumLength => string.Format(ValidationErrorMessages.MaximumLengthError, arguments),
            _ => string.Empty
        };
}

public enum ValidationErrorType
{
    NotNull,
    GreaterThanOrEqualTo,
    MaximumLength,
}