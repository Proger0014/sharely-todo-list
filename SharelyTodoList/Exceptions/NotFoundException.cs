using System.Net;

namespace SharelyTodoList.Exceptions;

public class NotFoundException : ApiException
{
    public NotFoundException(string message)
        : base(message, HttpStatusCode.NotFound) { }
}
