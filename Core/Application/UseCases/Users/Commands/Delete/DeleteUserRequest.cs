using MediatR;

namespace Application.UseCases.Users.Commands.Delete;

public sealed record DeleteUserRequest(Guid Id) : IRequest<DeleteUserResponse>;