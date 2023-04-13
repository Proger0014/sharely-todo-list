namespace SharelyTodoList.Utils;

public static class HeadersUtils
{
    /// <summary>
    /// Необходим для фронтенда. Если пароль на группу не ставили,
    /// то при переходе на группу по ссылке, получая данный заголовок,
    /// не будет необходимости вводить пароль, а сразу откроет страницу
    /// </summary>
    /// <param name="headers"></param>
    public static void WithoutPassword(IHeaderDictionary headers)
    {
        headers.Add("without-password", "1");
    }
}
