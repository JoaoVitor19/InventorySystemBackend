using Domain.Entities;
using Domain.Enums;
using MediatR;

namespace Application.UseCases.Sales.Commands.Update;

public sealed record UpdateSaleRequest(
        Guid Id,
        decimal Discount,
        PaymentType PaymentType,
        ICollection<SaleItem> SaleItems,
        int TableNumber = 0,
        string CustomerName = null,
        string CustomerEmail = null
    ) : IRequest<UpdateSaleResponse>;