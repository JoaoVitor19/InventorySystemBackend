namespace Domain.Interfaces
{
    public interface IAuthenticationService
    {
        Task<Token> GenerateToken(string email, string password);
    }
}
