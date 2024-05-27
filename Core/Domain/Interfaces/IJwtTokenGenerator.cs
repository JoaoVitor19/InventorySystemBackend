using Domain.Enums;

namespace Domain.Interfaces
{
    public interface IJwtTokenGenerator
    {
        Token GenerateToken(string email, ProfileType profileType);
    }
}
