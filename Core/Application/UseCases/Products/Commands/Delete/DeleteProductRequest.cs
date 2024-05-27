using MediatR;

namespace Application.UseCases.Products.Commands.Delete;

public sealed record DeleteProductRequest(Guid Id) : IRequest<DeleteProductResponse>;