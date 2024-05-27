using FluentValidation;

namespace Application.UseCases.Products.Commands.Delete;

public class DeleteProductValidator :
    AbstractValidator<DeleteProductRequest>
{
    public DeleteProductValidator()
    {
        RuleFor(x => x.Id).NotEmpty();
    }
}