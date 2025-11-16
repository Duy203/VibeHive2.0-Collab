using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VibeHive.Core.Models;

namespace VibeHive.Core.Interface
{
    public interface IAuthService
    {
        User Register(string username, string password, string role);
        User Login(string username, string password);
        string GenerateJwtToken(User user);
    }
}
