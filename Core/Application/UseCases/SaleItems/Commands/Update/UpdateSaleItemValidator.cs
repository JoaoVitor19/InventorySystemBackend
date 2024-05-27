using FluentValidation;

namespace Application.UseCases.SaleItems.Commands.Update;
public class UpdateSaleItemValidator : AbstractValidator<UpdateSaleItemRequest>
{
    public UpdateSaleItemValidator()
    {
        RuleFor(x => x.ProductId).NotEmpty();
        RuleFor(x => x.SaleId).NotEmpty();
        RuleFor(x => x.QuantitySold).GreaterThan(0);
        RuleFor(x => x.Price).GreaterThan(0).PrecisionScale(15, 2, false);
    }
}