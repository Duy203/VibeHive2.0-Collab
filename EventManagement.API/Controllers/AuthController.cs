using Microsoft.AspNetCore.Mvc;
using VibeHive.Common.DTOs;
using VibeHive.Core.Interface;

namespace EventManagement.API.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _auth;

        public AuthController(IAuthService auth)
        {
            _auth = auth;
        }

        [HttpPost("register")]
        public IActionResult Register(RegisterDto dto)
        {
            var user = _auth.Register(dto.Username, dto.Password, dto.Role);
            return Ok(user);
        }

        [HttpPost("login")]
        public IActionResult Login(LoginDto dto)
        {
            var user = _auth.Login(dto.Username, dto.Password);
            if (user == null)
                return Unauthorized();

            var token = _auth.GenerateJwtToken(user);
            return Ok(new { token });
        }
    }
}
