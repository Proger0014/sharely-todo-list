using Microsoft.AspNetCore.Mvc;

namespace SharelyTodoList.Controllers;

[Route("api/[controller]")]
[ApiController]
public abstract class BaseController : ControllerBase { }