using FluentValidation;

namespace Application.UseCases.Users.Commands.Update;
public class UpdateUserValidator : AbstractValidator<UpdateUserRequest>
{
    public UpdateUserValidator()
    {
        RuleFor(x => x.Email).NotEmpty().MaximumLength(50).EmailAddress();
        RuleFor(x => x.FirstName).NotEmpty().MinimumLength(3).MaximumLength(25);
        RuleFor(x => x.LastName).NotEmpty().MinimumLength(3).MaximumLength(25);
    }
}