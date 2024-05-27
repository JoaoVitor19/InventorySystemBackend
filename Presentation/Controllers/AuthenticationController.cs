using Domain.Interfaces;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using System.Security.Authentication;

namespace InventorySystem.API.Controllers
{
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService;
        public AuthenticationController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var token = _authenticationService.GenerateToken(request.Email, request.Password);
                return Ok(new { Token = token });
            }
            catch (AuthenticationException ex)
            {
                return BadRequest(new { Message = ex.Message });
            }
        }
    }
}
