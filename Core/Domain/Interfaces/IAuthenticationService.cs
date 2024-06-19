using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IAuthenticationService
    {
        Token GenerateToken(User user);
    }
}
