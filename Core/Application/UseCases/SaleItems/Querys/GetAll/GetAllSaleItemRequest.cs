using MediatR;

namespace Application.UseCases.SaleItems.Querys.GetAll;

public sealed record GetAllSaleItemRequest : IRequest<List<GetAllSaleItemResponse>>;