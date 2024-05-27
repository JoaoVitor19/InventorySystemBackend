using AutoMapper;
using Domain.Entities;

namespace Application.UseCases.Users.Querys.GetAll;

public sealed class GetAllUserMapper : Profile
{
    public GetAllUserMapper()
    {
        CreateMap<User, GetAllUserResponse>();
    }
}