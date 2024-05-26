using FluentValidation;

namespace Application.UseCases.GetUser
{
    public sealed class GetUserValidator : AbstractValidator<GetUserRequest>
    {
        public GetUserValidator() 
        {
            RuleFor(x => x.Id).NotEmpty();
        }
    }
}
