using MediatR;

namespace Application.UseCases.SaleItems.Commands.Create
{
    public sealed record CreateSaleItemRequest(
        Guid SaleId, Guid ProductId, int QuantitySold, decimal Price
        ) : IRequest<CreateSaleItemResponse>
    {
    }
}
