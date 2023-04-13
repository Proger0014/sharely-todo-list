using SharelyTodoList.Utils;

namespace SharelyTodoList.Extensions;

public static class HeadersExtensions
{
    public static void AddWithoutPassword(this IHeaderDictionary headers)
    {
        HeadersUtils.WithoutPassword(headers);
    }
}
