using Microsoft.AspNetCore.Mvc;
using SharelyTodoList.Models.Group;
using SharelyTodoList.DTOs.TaskGroupApiDto;
using SharelyTodoList.Interfaces.Services;

namespace SharelyTodoList.Controllers;

public class GroupsController : BaseController
{
    private readonly IGroupService _groupService;

    public GroupsController(IGroupService groupService)
    {
        _groupService = groupService;
    }

    [HttpGet("{id}")]
    public GroupPreviewResponse GetByIdPreview(long id)
    {
        Group existsGroup = _groupService
            .GetById(id);

        return new GroupPreviewResponse()
        {
            Id = id,
            Name = existsGroup.Name
        };
    }

    [HttpPost]
    public GroupCreatedResponse CreateGroup([FromBody] GroupCreateRequest request)
    {
        long idNewTaskGroup = _groupService
            .CreateGroup(request.Name, request.Password);

        return new GroupCreatedResponse()
        {
            Id = idNewTaskGroup
        };
    }
}
