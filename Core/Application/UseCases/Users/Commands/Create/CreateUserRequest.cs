using MediatR;

namespace Application.UseCases.Users.Commands.Create
{
    public sealed record CreateUserRequest(string Email, string FirstName, string LastName, string Password) : IRequest<CreateUserResponse>
    {
    }
}
