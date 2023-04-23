using System.Net;

namespace SharelyTodoList.Exceptions;

public class AuthException : ApiException
{
    public AuthException(string message) 
        : base(message, HttpStatusCode.Unauthorized) { }
}