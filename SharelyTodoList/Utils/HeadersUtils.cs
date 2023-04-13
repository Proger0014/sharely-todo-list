namespace SharelyTodoList.Utils;

public static class HeadersUtils
{
    public static void WithoutPassword(IHeaderDictionary headers)
    {
        headers.Add("without-password", "1");
    }
}
