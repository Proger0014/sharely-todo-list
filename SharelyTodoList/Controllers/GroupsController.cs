using Microsoft.AspNetCore.Mvc;
using SharelyTodoList.Models.TaskGroup;
using SharelyTodoList.DTOs.TaskGroupApiDto;
using SharelyTodoList.Services;
using SharelyTodoList.Extensions;

namespace SharelyTodoList.Controllers;

public class GroupsController : BaseController
{
    private readonly TaskGroupService _taskGroupService;

    public GroupsController(TaskGroupService taskGroupService)
    {
        _taskGroupService = taskGroupService;
    }

    [HttpGet("{id}")]
    public GroupPreviewResponse GetByIdPreview(long id)
    {
        HttpContext.Response.Headers
            .AddPasswordRequired();

        Group existsGroup = _taskGroupService
            .GetById(id);

        return new GroupPreviewResponse()
        {
            Id = id,
            Name = existsGroup.Name
        };
    }

    [HttpPost]
    public GroupCreatedResponse CreateTaskGroup([FromBody] GroupCreateRequest request)
    {
        long idNewTaskGroup = _taskGroupService
            .CreateTaskGroup(request.Name, request.Password);

        return new GroupCreatedResponse()
        {
            Id = idNewTaskGroup
        };
    }
}
