using FluentValidation;

namespace Application.UseCases.SaleItems.Querys.Get
{
    public sealed class GetSaleItemValidator : AbstractValidator<GetSaleItemRequest>
    {
        public GetSaleItemValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
        }
    }
}
