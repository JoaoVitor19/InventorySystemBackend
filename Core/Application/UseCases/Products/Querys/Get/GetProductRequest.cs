using MediatR;

namespace Application.UseCases.Products.Querys.Get
{
    public sealed record GetProductRequest(Guid Id) : IRequest<GetProductResponse>
    {
    }
}
