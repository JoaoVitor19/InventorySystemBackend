using MediatR;

namespace Application.UseCases.CreateUser
{
    public sealed record CreateUserRequest(string Email, string FirstName, string LastName, string Password) : IRequest<CreateUserResponse>
    {
    }
}
