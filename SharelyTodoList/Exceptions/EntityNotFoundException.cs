using System.Net;
using SharelyTodoList.Interfaces;

namespace SharelyTodoList.Exceptions;

public class EntityNotFoundException : ApiException
{
    public EntityNotFoundException(string message)
        : base(message, HttpStatusCode.NotFound) { }
}
