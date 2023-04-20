using SharelyTodoList.Validators;
using FluentValidation.AspNetCore;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using SharelyTodoList.Contracts.Groups;
using SharelyTodoList.Contracts.Groups.GetByIdPreviewRequest;
using SharelyTodoList.Contracts.Groups.GroupCreateRequest;
using SharelyTodoList.Models.Group;
using SharelyTodoList.Interfaces.Services;

namespace SharelyTodoList.Controllers;

public class GroupsController : BaseApiController
{
    private readonly IGroupService _groupService;
    private readonly BaseValidators<Group> _groupValidators;
    
    public GroupsController(IGroupService groupService, BaseValidators<Group> groupValidators)
    {
        _groupService = groupService;
        _groupValidators = groupValidators;
    }

    [HttpGet("{groupId}")]
    public async Task<IActionResult> GetByIdPreview(long groupId)
    {
        ValidationResult result = await _groupValidators
            .Validate(new GetByIdPreviewRequest()
                {
                    GroupId = groupId
                });

        if (!result.IsValid)
        {
            result.AddToModelState(ModelState);
            return ValidationProblem();
        }
        
        Group existsGroup = await _groupService
            .GetById(groupId);

        return Ok(new GroupPreviewResponse()
        {
            Id = groupId,
            Name = existsGroup.Name
        });
    }

    [HttpPost]
    public async Task<IActionResult> CreateGroup([FromBody] CreateGroupRequest request)
    {
        ValidationResult result = await _groupValidators.Validate(request);

        if (!result.IsValid)
        {
            result.AddToModelState(ModelState);
            return ValidationProblem();
        }
        
        long idNewTaskGroup = await _groupService
            .CreateGroup(request.Name, request.Password);

        return Ok(new GroupCreatedResponse()
        {
            Id = idNewTaskGroup
        });
    }
}
