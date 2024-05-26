using MediatR;

namespace Application.UseCases.UpdateUser;

public sealed record UpdateUserRequest(Guid Id, string Email, string FirstName, string LastName) : IRequest<UpdateUserResponse>;