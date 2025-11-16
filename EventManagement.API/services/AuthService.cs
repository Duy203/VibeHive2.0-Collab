using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using VibeHive.Core.Interface;
using VibeHive.Core.Models;
using VibeHive.Common;
namespace EventManagement.API.services
{
    public class AuthService : IAuthService
    {
        private readonly List<User> _users = new();
        private int _idCounter = 1;
        private readonly JwtSetting _jwt;

        public AuthService(JwtSetting jwt)
        {
            _jwt = jwt;

            //default to admin
            _users.Add(new User
            {
                Id = _idCounter++,
                Username = "admin",
                Password = "admin",
                Role = "Admin"
            });
        }

        public User Register(string username, string password, string role)
        {
            var user = new User
            {
                Id = _idCounter++,
                Username = username,
                Password = password,
                Role = role
            };

            _users.Add(user);
            return user;
        }

        public User Login(string username, string password)
        {
            return _users.FirstOrDefault(u => u.Username == username && u.Password == password);
        }

        public string GenerateJwtToken (User user)
        {
            var claims = new[]
            {
                new Claim("Id", user.Id.ToString()),
                new Claim(ClaimTypes.Role, user.Role)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwt.Key));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _jwt.Issuer,
                audience: _jwt.Audience,
                claims: claims,
                expires: DateTime.Now.AddHours(1),
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
