using Microsoft.AspNetCore.Mvc;
using SharelyTodoList.Models.TaskGroup;
using SharelyTodoList.DTOs.TaskGroupApiDto;
using SharelyTodoList.Services;
using SharelyTodoList.Extensions;

namespace SharelyTodoList.Controllers;

public class TaskGroupController : BaseController
{
    private readonly TaskGroupService _taskGroupService;

    public TaskGroupController(TaskGroupService taskGroupService)
    {
        _taskGroupService = taskGroupService;
    }

    [HttpGet("{id}")]
    public TaskGroupPreviewResponse GetByIdPreview(long id)
    {
        HttpContext.Response.Headers
            .AddPasswordRequired();

        TaskGroup existsTaskGroup = _taskGroupService
            .GetById(id);

        return new TaskGroupPreviewResponse()
        {
            Id = id,
            Name = existsTaskGroup.Name
        };
    }

    [HttpPost]
    public TaskGroupCreatedResponse CreateTaskGroup([FromBody] TaskGroupCreateRequest request)
    {
        long idNewTaskGroup = _taskGroupService
            .CreateTaskGroup(request.Name, request.Password);

        return new TaskGroupCreatedResponse()
        {
            Id = idNewTaskGroup
        };
    }
}
