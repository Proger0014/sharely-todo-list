using FluentValidation.AspNetCore;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using SharelyTodoList.Constants;
using SharelyTodoList.Contracts.AccessTokens;
using SharelyTodoList.Contracts.AccessTokens.LoginRequest;
using SharelyTodoList.Exceptions;
using SharelyTodoList.Interfaces.Services;
using SharelyTodoList.Models.AccessToken;
using SharelyTodoList.Validators;

namespace SharelyTodoList.Controllers;

public class AuthController : BaseApiController
{
    private readonly IAccessTokenService _accessTokenService;
    private readonly IGroupService _groupService;
    private readonly BaseValidators<AccessToken> _accessTokensValidators;

    public AuthController(
        IAccessTokenService accessTokenService,
        IGroupService groupService,
        BaseValidators<AccessToken> accessTokensValidators)
    {
        _accessTokenService = accessTokenService;
        _groupService = groupService;
        _accessTokensValidators = accessTokensValidators;
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginRequest loginRequest)
    {
        ValidationResult result = await _accessTokensValidators
            .Validate(loginRequest);
    
        if (!result.IsValid)
        {
            result.AddToModelState(ModelState);
            return ValidationProblem();
        }

        bool isValidPassword = await _groupService
            .IsValidPassword(loginRequest.GroupId, loginRequest.Password);
        
        if (!isValidPassword)
        {
            throw new AuthException(string.Format(
                ExceptionMessages.UnvalidPassword, loginRequest.GroupId));
        }

        string accessToken = await _accessTokenService
            .CreateAccessToken(loginRequest.GroupId);

        return Ok(new LoginResponse()
        {
            AccessToken = accessToken
        });
    }
}