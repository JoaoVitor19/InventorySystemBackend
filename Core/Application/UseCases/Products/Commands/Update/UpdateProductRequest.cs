using MediatR;

namespace Application.UseCases.Products.Commands.Update;

public sealed record UpdateProductRequest(
        Guid Id,
        string Name,
        string Description,
        string Category,
        decimal InitialPrice,
        decimal FinalPrice,
        int StockQuantity = 0,
        string ImagePath = null,
        string Base64Image = null
    ) : IRequest<UpdateProductResponse>;