using MediatR;

namespace Application.UseCases.SaleItems.Querys.Get
{
    public sealed record GetSaleItemRequest(Guid Id) : IRequest<GetSaleItemResponse>
    {
    }
}
