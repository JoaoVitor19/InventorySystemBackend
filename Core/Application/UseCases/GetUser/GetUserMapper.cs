using AutoMapper;
using Domain.Entities;

namespace Application.UseCases.GetUser
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
