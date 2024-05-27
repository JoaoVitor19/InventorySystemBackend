using MediatR;

namespace Application.UseCases.Users.Commands.Update;

public sealed record UpdateUserRequest(Guid Id, string Email, string FirstName, string LastName) : IRequest<UpdateUserResponse>;