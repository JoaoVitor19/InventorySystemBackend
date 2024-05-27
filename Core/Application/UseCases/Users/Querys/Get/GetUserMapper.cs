using AutoMapper;
using Domain.Entities;

namespace Application.UseCases.Users.Querys.Get
{
    public sealed class UpdateUserMapper : Profile
    {
        public UpdateUserMapper()
        {
            CreateMap<GetUserRequest, User>();
            CreateMap<User, GetUserResponse>();
        }
    }
}
