using MediatR;

namespace Application.UseCases.Products.Commands.Create
{
    public sealed record CreateProductRequest(
        string Name,
        string Description,
        string Category,
        decimal InitialPrice,
        decimal FinalPrice,
        int StockQuantity = 0,
        string Base64Image = null
        ) : IRequest<CreateProductResponse>
    {
    }
}
