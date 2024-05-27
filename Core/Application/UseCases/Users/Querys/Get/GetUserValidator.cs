using FluentValidation;

namespace Application.UseCases.Users.Querys.Get
{
    public sealed class GetUserValidator : AbstractValidator<GetUserRequest>
    {
        public GetUserValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
        }
    }
}
