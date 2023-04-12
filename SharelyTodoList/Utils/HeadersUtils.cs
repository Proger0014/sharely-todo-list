namespace SharelyTodoList.Utils;

public static class HeadersUtils
{
    public static void PasswordRequired(IHeaderDictionary headers)
    {
        headers.Add("password-required", "1");
    }
}
