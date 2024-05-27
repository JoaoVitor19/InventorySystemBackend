using FluentValidation;

namespace Application.UseCases.SaleItems.Commands.Create
{
    public sealed class CreateSaleItemValidator : AbstractValidator<CreateSaleItemRequest>
    {
        public CreateSaleItemValidator()
        {
            RuleFor(x => x.ProductId).NotEmpty();
            RuleFor(x => x.SaleId).NotEmpty();
            RuleFor(x => x.QuantitySold).GreaterThan(0);
            RuleFor(x => x.Price).GreaterThan(0).PrecisionScale(15, 2, false);
        }
    }
}
