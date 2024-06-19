using Domain.Entities;
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

    public Token GenerateToken(User user)
    {
        var token = _jwtTokenGenerator.GenerateToken(user.Email, user.ProfileType);
        return token;
    }
}