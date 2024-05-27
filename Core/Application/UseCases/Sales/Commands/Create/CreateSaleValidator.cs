using FluentValidation;

namespace Application.UseCases.Sales.Commands.Create
{
    public sealed class CreateSaleValidator : AbstractValidator<CreateSaleRequest>
    {
        public CreateSaleValidator()
        {
            RuleFor(x => x.PaymentType).NotEmpty();
            RuleFor(x => x.CustomerName).MaximumLength(60);
            RuleFor(x => x.CustomerEmail).MaximumLength(256);
            RuleFor(x => x.Discount).GreaterThan(0).PrecisionScale(15, 2, false);
        }
    }
}
