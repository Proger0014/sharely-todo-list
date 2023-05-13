namespace SharelyTodoList.Constants;

public static class ValidationErrorMessages
{
    public const string GreaterThanOrEqualToError = "Значение {0} не может быть меньше нуля";
    public const string GreaterThanError = "Значение {0} должно быть больше {1}";
    public const string NotNullError = "Требуется указать {0}";
    public const string NotEmptyError = "Требуется указать {0} или изменить дефолтное значение";
    public const string MaximumLengthError = "Максимальная длина строки {0} не должна превышать {1} символов";
}