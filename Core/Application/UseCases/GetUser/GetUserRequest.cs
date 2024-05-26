using MediatR;

namespace Application.UseCases.GetUser
{
    public sealed record GetUserRequest(Guid Id) : IRequest<GetUserResponse>
    {
    }
}
