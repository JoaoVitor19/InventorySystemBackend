using Domain.Entities;
using Domain.Enums;
using MediatR;

namespace Application.UseCases.Sales.Commands.Create
{
    public sealed record CreateSaleRequest(
        Guid Id,
        decimal Discount,
        PaymentType PaymentType,
        ICollection<SaleItem> SaleItems,
        int TableNumber = 0,
        string CustomerName = null,
        string CustomerEmail = null
        ) : IRequest<CreateSaleResponse>
    {
    }
}
