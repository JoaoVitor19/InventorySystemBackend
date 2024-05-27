using MediatR;

namespace Application.UseCases.Products.Querys.GetAll;

public sealed record GetAllProductRequest : IRequest<List<GetAllProductResponse>>;