using FluentValidation;
using SharelyTodoList.Utils;
using SharelyTodoList.Models;

namespace SharelyTodoList.Contracts.Groups.GroupCreateRequest;

public class CreateGroupRequestRules : AbstractValidator<CreateGroupRequest>
{
    public CreateGroupRequestRules()
    {
        const string name = nameof(CreateGroupRequest.Name);
        const string password = nameof(CreateGroupRequest.Password);
        
        RuleFor(target => target.Name)
            .NotEmpty()
            .WithMessage(ValidationErrorUtils
                .GetMessageFrom(ValidationErrorType.NotEmpty, name))
            .MaximumLength(GroupModel.NameMaxLength)
            .WithMessage(ValidationErrorUtils
                .GetMessageFrom(ValidationErrorType.MaximumLength, name, GroupModel.NameMaxLength));

        RuleFor(target => target.Password)
            .NotEmpty()
            .WithMessage(ValidationErrorUtils
                .GetMessageFrom(ValidationErrorType.NotEmpty, password))
            .MaximumLength(GroupModel.PasswordMaxLength)
            .WithMessage(ValidationErrorUtils
                .GetMessageFrom(ValidationErrorType.MaximumLength, name, GroupModel.PasswordMaxLength));
    }
}