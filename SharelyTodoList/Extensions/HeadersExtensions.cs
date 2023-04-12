using SharelyTodoList.Utils;

namespace SharelyTodoList.Extensions;

public static class HeadersExtensions
{
    public static void AddPasswordRequired(this IHeaderDictionary headers)
    {
        HeadersUtils.PasswordRequired(headers);
    }
}
