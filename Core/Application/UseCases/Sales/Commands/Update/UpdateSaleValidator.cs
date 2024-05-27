using Application.UseCases.Sales.Commands.Update;
using FluentValidation;

namespace Application.UseCases.Users.Commands.Update;
public class UpdateSaleValidator : AbstractValidator<UpdateSaleRequest>
{
    public UpdateSaleValidator()
    {
        RuleFor(x => x.PaymentType).NotEmpty();
        RuleFor(x => x.CustomerName).MaximumLength(60);
        RuleFor(x => x.CustomerEmail).MaximumLength(256);
        RuleFor(x => x.Discount).GreaterThan(0).PrecisionScale(15, 2, false);
    }
}