using System.Net;

namespace SharelyTodoList.Exceptions;

public class EntityNotFoundException : ApiException
{
    public EntityNotFoundException(string message)
        : base(message, HttpStatusCode.NotFound) { }
}
