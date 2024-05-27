using AutoMapper;
using Domain.Entities;

namespace Application.UseCases.Users.Commands.Delete;

public sealed class DeleteUserMapper : Profile
{
    public DeleteUserMapper()
    {
        CreateMap<DeleteUserRequest, User>();
        CreateMap<User, DeleteUserResponse>();
    }
}