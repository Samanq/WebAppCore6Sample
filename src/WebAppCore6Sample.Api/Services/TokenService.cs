using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using WebAppCore6Sample.Api.Entities;

namespace WebAppCore6Sample.Api.Services
{
    public class TokenService
    {
        public string GenerateToken(User user)
        {
            List<Claim> claim = new List<Claim>()
            {
                new Claim(ClaimTypes.Name, "")
            };
            return "sd";
        }
    }
}
