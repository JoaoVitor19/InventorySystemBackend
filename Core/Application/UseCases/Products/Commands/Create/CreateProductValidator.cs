using FluentValidation;

namespace Application.UseCases.Products.Commands.Create
{
    public sealed class CreateProductValidator : AbstractValidator<CreateProductRequest>
    {
        public CreateProductValidator()
        {
            RuleFor(x => x.Name).NotEmpty().MinimumLength(3).MaximumLength(50);
            RuleFor(x => x.Description).MaximumLength(500);
            RuleFor(x => x.Category).NotEmpty().MaximumLength(200);
            RuleFor(x => x.FinalPrice).GreaterThan(0).PrecisionScale(15, 2, false);
        }
    }
}
