using MediatR;

namespace Application.UseCases.DeleteUser;

public sealed record DeleteUserRequest(Guid Id) : IRequest<DeleteUserResponse>;