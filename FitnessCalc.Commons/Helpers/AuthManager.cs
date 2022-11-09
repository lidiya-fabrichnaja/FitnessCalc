using System.Security.Claims;
using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;

namespace FitnessCalc.Commons.Helpers
{
    public class AuthManager
    {
        public const string ISSUER = "FitnessCalc";
        public const string AUDIENCE = "FitnessCalcAPI";
        const string KEY = "fitness_calc(foods4578678)";
        public const int LIFETIME = 1;

        public static SymmetricSecurityKey GetSymmetricSecurityKey()
        {
            return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(KEY));
        }

        public static string GenerateToken(List<Claim> claims)
        { 
            JwtSecurityToken token = new(
                ISSUER,
                AUDIENCE,
                claims,
                expires : DateTime.Now.AddDays(LIFETIME),
                signingCredentials : new SigningCredentials(GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256)
            );

            return new JwtSecurityTokenHandler().WriteToken(token);

        }

    }
}