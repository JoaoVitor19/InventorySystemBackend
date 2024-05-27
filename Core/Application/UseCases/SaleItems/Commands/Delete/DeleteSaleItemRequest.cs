using MediatR;

namespace Application.UseCases.SaleItems.Commands.Delete;

public sealed record DeleteSaleItemRequest(Guid Id) : IRequest<DeleteSaleItemResponse>;