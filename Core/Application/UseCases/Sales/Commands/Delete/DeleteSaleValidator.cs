using FluentValidation;

namespace Application.UseCases.Sales.Commands.Delete;

public class DeleteSaleValidator :
    AbstractValidator<DeleteSaleRequest>
{
    public DeleteSaleValidator()
    {
        RuleFor(x => x.Id).NotEmpty();
    }
}