using Domain.Interfaces;
using System.Security.Authentication;

public class AuthenticationService : IAuthenticationService
{
    private readonly IUserRepository _userRepository;
    private readonly IJwtTokenGenerator _jwtTokenGenerator;

    public AuthenticationService(IUserRepository userRepository, IJwtTokenGenerator jwtTokenGenerator)
    {
        _userRepository = userRepository;
        _jwtTokenGenerator = jwtTokenGenerator;
    }

    public async Task<Token> GenerateToken(string email, string password)
    {
        CancellationToken cancellation = CancellationToken.None;
        var user = await _userRepository.GetByEmail(email, cancellation);

        if (user == null || !user.Password.Equals(password))
        {
            throw new AuthenticationException("Invalid username or password");
        }

        var token = _jwtTokenGenerator.GenerateToken(user.Email, user.ProfileType);
        return token;
    }
}