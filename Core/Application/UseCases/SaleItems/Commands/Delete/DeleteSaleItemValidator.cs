using FluentValidation;

namespace Application.UseCases.SaleItems.Commands.Delete;

public class DeleteSaleItemValidator :
    AbstractValidator<DeleteSaleItemRequest>
{
    public DeleteSaleItemValidator()
    {
        RuleFor(x => x.Id).NotEmpty();
    }
}