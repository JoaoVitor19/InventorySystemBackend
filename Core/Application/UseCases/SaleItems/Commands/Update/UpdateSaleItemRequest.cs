using MediatR;
using System;

namespace Application.UseCases.SaleItems.Commands.Update;

public sealed record UpdateSaleItemRequest(
    Guid Id, Guid SaleId, Guid ProductId, int QuantitySold, decimal Price
    ) : IRequest<UpdateSaleItemResponse>;