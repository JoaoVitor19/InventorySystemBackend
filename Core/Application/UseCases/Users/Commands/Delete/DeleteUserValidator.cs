using FluentValidation;

namespace Application.UseCases.Users.Commands.Delete;

public class DeleteUserValidator :
    AbstractValidator<DeleteUserRequest>
{
    public DeleteUserValidator()
    {
        RuleFor(x => x.Id).NotEmpty();
    }
}