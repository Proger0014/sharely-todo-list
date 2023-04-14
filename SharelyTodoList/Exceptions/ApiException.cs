using System.Net;
using SharelyTodoList.Interfaces;

namespace SharelyTodoList.Exceptions;

public abstract class ApiException : Exception
{
    public HttpStatusCode StatusCode { get; init; }

    protected ApiException(string message, HttpStatusCode statusCode)
        : base(message)
    {
        StatusCode = statusCode;
    }
}