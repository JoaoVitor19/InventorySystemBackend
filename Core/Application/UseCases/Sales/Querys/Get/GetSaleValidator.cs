using FluentValidation;

namespace Application.UseCases.Sales.Querys.Get
{
    public sealed class GetSaleValidator : AbstractValidator<GetSaleRequest>
    {
        public GetSaleValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
        }
    }
}
