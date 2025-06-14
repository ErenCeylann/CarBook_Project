using CarBook.Application.Dtos;
using CarBook.Application.Features.Mediator.Result.AppUserResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;

namespace CarBook.Application.Tools
{
    public class JwtTokenGenerator
    {
        public static TokenResponseDto GenerateToken(GetCheckAppUserQueryResult result)
        {
            var cliams = new List<Claim>();
            
            if (!string.IsNullOrWhiteSpace(result.Role))
                cliams.Add(new Claim(ClaimTypes.Role, result.Role));

                cliams.Add(new Claim(ClaimTypes.NameIdentifier, result.Id.ToString()));

            if (!string.IsNullOrWhiteSpace(result.UserName))
                cliams.Add(new Claim("UserName", result.UserName));


            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtTokenDefaults.Key));
            var signinCredantials=new SigningCredentials(key,SecurityAlgorithms.HmacSha256);
            var expireDate = DateTime.UtcNow.AddDays(JwtTokenDefaults.Expire);
            JwtSecurityToken jwtSecurityToken = new JwtSecurityToken(issuer:JwtTokenDefaults.ValidIssuer,audience:JwtTokenDefaults.ValidAuidience,claims:cliams,notBefore:DateTime.UtcNow,expires:expireDate,signingCredentials:signinCredantials);

            JwtSecurityTokenHandler jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            return new TokenResponseDto(jwtSecurityTokenHandler.WriteToken(jwtSecurityToken),expireDate);
        }
    }
}
