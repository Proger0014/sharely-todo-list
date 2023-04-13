using Microsoft.AspNetCore.Mvc;
using SharelyTodoList.Models.Group;
using SharelyTodoList.DTOs.TaskGroupApiDto;
using SharelyTodoList.Services;
using SharelyTodoList.Extensions;

namespace SharelyTodoList.Controllers;

public class GroupsController : BaseController
{
    private readonly GroupService _groupService;

    public GroupsController(GroupService groupService)
    {
        _groupService = groupService;
    }

    [HttpGet("{id}")]
    public GroupPreviewResponse GetByIdPreview(long id)
    {
        HttpContext.Response.Headers
            .AddPasswordRequired();

        Group existsGroup = _groupService
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
        long idNewTaskGroup = _groupService
            .CreateTaskGroup(request.Name, request.Password);

        return new GroupCreatedResponse()
        {
            Id = idNewTaskGroup
        };
    }
}
