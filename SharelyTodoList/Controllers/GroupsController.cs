using SharelyTodoList.Validators;
using FluentValidation.AspNetCore;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using SharelyTodoList.Constants;
using SharelyTodoList.Contracts.AccessTokens;
using SharelyTodoList.Contracts.AccessTokens.ConnectRequest;
using SharelyTodoList.Contracts.Groups;
using SharelyTodoList.Contracts.Groups.GetByIdPreviewRequest;
using SharelyTodoList.Contracts.Groups.GroupCreateRequest;
using SharelyTodoList.Exceptions;
using SharelyTodoList.Models;
using SharelyTodoList.Interfaces.Services;

namespace SharelyTodoList.Controllers;

public class GroupsController : BaseApiController
{
    private readonly IGroupService _groupService;
    private readonly IAccessTokenService _accessTokenService;
    private readonly BaseValidators<GroupModel> _groupValidators;
    private readonly BaseValidators<AccessTokenModel> _accessTokenValidators;

    public GroupsController(
        IGroupService groupService,
        IAccessTokenService accessTokenService,
        BaseValidators<GroupModel> groupValidators,
        BaseValidators<AccessTokenModel> accessTokenValidators)
    {
        _groupService = groupService;
        _accessTokenService = accessTokenService;
        _groupValidators = groupValidators;
        _accessTokenValidators = accessTokenValidators;
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
        
        GroupModel existsGroup = await _groupService
            .GetById(groupId);

        return Ok(new GroupPreviewResponse()
        {
            Id = groupId,
            Name = existsGroup.Name
        });
    }

    [HttpPost("connect")]
    public async Task<IActionResult> ConnectToGroup([FromBody] ConnectRequest connectRequest)
    {
        ValidationResult result = await _accessTokenValidators
            .Validate(connectRequest);

        if (!result.IsValid)
        {
            result.AddToModelState(ModelState);
            return ValidationProblem();
        }

        bool isValidPassword = await _groupService
            .IsValidPassword(connectRequest.GroupId, connectRequest.Password);

        if (!isValidPassword)
        {
            throw new AuthException(string.Format(
                ExceptionMessages.UnvalidPassword, connectRequest.Password));
        }

        string accessToken = await _accessTokenService
            .CreateAccessToken(connectRequest.GroupId);

        return Ok(new ConnectResponse()
        {
            AccessToken = accessToken
        });
    }

    [HttpPost("create")]
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
