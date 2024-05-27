using AutoMapper;
using Domain.Entities;

namespace Application.UseCases.Users.Commands.Update;
public sealed class UpdateUserMapper : Profile
{
    public UpdateUserMapper()
    {
        CreateMap<UpdateUserRequest, User>();
        CreateMap<User, UpdateUserResponse>();
    }
}