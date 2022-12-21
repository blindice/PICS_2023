using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using PICS_2023.Features.Auth.DTO;
using PICS_2023.Features.Auth.Interface;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace PICS_2023.Features.Auth.Service
{
    public class JWTService : IJWTService
    {
        IConfiguration _config;
        public JWTService(IConfiguration config) => _config = config;

        public async Task<string> GenerateJwtTokenAsync(UserDto user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            SecurityToken token = null;

            await Task.Run(() =>
            {
                var key = Encoding.ASCII.GetBytes(_config["Jwt:key"]);
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new[] {
                    new Claim("id", user.Id.ToString()),
                    new Claim("employeeNo", user.EmployeeNo),
                    new Claim("apoAccount", user.ApoAccount),
                    new Claim("fullName", user.FullName),
                    new Claim("roleId", user.RoleId.ToString()),
                }),
                    Expires = DateTime.UtcNow.AddHours(1),
                    Issuer = _config["Jwt:Issuer"],
                    Audience = _config["Jwt:Audience"],
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                };
                token = tokenHandler.CreateToken(tokenDescriptor);

            });
            return tokenHandler.WriteToken(token);
        }
    }
}
