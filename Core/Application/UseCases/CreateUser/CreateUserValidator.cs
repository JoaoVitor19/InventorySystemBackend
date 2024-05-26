using FluentValidation;

namespace Application.UseCases.CreateUser
{
    public sealed class CreateUserValidator : AbstractValidator<CreateUserRequest>
    {
        public CreateUserValidator() 
        {
            RuleFor(x => x.Email).NotEmpty().MaximumLength(50).EmailAddress();
            RuleFor(x => x.FirstName).NotEmpty().MinimumLength(3).MaximumLength(30);
            RuleFor(x => x.LastName).NotEmpty().MinimumLength(3).MaximumLength(30);
            RuleFor(x => x.Password).NotEmpty().MinimumLength(3).MaximumLength(30);
        }
    }
}
