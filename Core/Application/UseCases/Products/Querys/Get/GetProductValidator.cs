using FluentValidation;

namespace Application.UseCases.Products.Querys.Get
{
    public sealed class GetProductValidator : AbstractValidator<GetProductRequest>
    {
        public GetProductValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
        }
    }
}
