using MediatR;

namespace Application.UseCases.Users.Querys.Get
{
    public sealed record GetUserRequest(Guid Id) : IRequest<GetUserResponse>
    {
    }
}
