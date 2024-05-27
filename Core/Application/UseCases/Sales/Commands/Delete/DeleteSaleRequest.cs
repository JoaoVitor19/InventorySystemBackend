using MediatR;

namespace Application.UseCases.Sales.Commands.Delete;

public sealed record DeleteSaleRequest(Guid Id) : IRequest<DeleteSaleResponse>;