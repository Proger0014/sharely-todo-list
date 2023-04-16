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

    [HttpGet("{groupId}")]
    public async Task<GroupPreviewResponse> GetByIdPreview(long groupId)
    {
        Group existsGroup = await _groupService
            .GetById(groupId);

        return new GroupPreviewResponse()
        {
            Id = groupId,
            Name = existsGroup.Name
        };
    }

    [HttpPost]
    public async Task<GroupCreatedResponse> CreateGroup([FromBody] GroupCreateRequest request)
    {
        long idNewTaskGroup = await _groupService
            .CreateGroup(request.Name, request.Password);

        return new GroupCreatedResponse()
        {
            Id = idNewTaskGroup
        };
    }
}
