using MediatR;

namespace Application.UseCases.Sales.Querys.GetAll;

public sealed record GetAllSaleRequest : IRequest<List<GetAllSaleResponse>>;