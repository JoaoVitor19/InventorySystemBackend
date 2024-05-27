using MediatR;

namespace Application.UseCases.Sales.Querys.Get
{
    public sealed record GetSaleRequest(Guid Id) : IRequest<GetSaleResponse>
    {
    }
}
