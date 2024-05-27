using MediatR;

namespace Application.UseCases.Users.Querys.GetAll;

public sealed record GetAllUserRequest : IRequest<List<GetAllUserResponse>>;