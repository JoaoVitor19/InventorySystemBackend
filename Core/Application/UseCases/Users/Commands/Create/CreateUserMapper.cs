using AutoMapper;
using Domain.Entities;

namespace Application.UseCases.Users.Commands.Create
{
    public sealed class CreateUserMapper : Profile
    {
        public CreateUserMapper()
        {
            CreateMap<CreateUserRequest, User>();
            CreateMap<User, CreateUserResponse>();
        }
    }
}
