using SharelyTodoList.Constants;

namespace SharelyTodoList.Utils;

public static class ValidationErrorUtils
{
    public static string GetMessageFrom(
        ValidationErrorType errorType, params object[] arguments) => errorType switch
        {
            ValidationErrorType.NotNull => string.Format(ValidationErrorMessages.NotNullError, arguments),
            ValidationErrorType.GreaterThanOrEqualTo => string.Format(ValidationErrorMessages.GreaterThanOrEqualToError, arguments),
            ValidationErrorType.GreaterThan => string.Format(ValidationErrorMessages.GreaterThanError, arguments),
            ValidationErrorType.MaximumLength => string.Format(ValidationErrorMessages.MaximumLengthError, arguments),
            ValidationErrorType.NotEmpty => string.Format(ValidationErrorMessages.NotEmptyError, arguments),
            _ => string.Empty
        };
}

public enum ValidationErrorType
{
    NotNull,
    GreaterThanOrEqualTo,
    GreaterThan,
    MaximumLength,
    NotEmpty
}