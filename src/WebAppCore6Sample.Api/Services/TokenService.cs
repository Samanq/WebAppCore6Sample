using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using WebAppCore6Sample.Api.Entities;

namespace WebAppCore6Sample.Api.Services;

public class TokenService
{
    public string GenerateToken(User user)
    {
        // 1. Step one creating Claims.
        List<Claim> claims = new List<Claim>()
        {
            new Claim(ClaimTypes.Email, user.Email),
            new Claim(ClaimTypes.Role, "Admin")
        };

        // 2. Step two: Creating security key using a secret key that should kept safe.
        var securityKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("asdkjhasmbdnla@83uj3nHj349"));

        // 3. Creating sigin credential using the above security key.
        var ceredntial = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512Signature);

        // 4. Generating the token with above ceredential and claims.
        var token = new JwtSecurityToken(
                    claims: claims,
                    signingCredentials: ceredntial,
                    expires: DateTime.UtcNow.AddDays(1));

        var jwt = new JwtSecurityTokenHandler().WriteToken(token);

        return jwt;
    }
}
