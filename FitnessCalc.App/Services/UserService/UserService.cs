using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using FitnessCalc.App.ViewModels.UserProfile;
using FitnessCalc.Commons.Contracts;
using Microsoft.AspNetCore.Authentication.Cookies;
using FitnessCalc.Commons.Helpers;

namespace FitnessCalc.App.Services.UserService
{
    public class UserService : IService, IUserService
    {
        List<LoginRequest> users = new List<LoginRequest> {
            new LoginRequest {Login = "admin" , Password = "12345"}
        };
        public async Task<LoginViewModel> Auth(LoginRequest model)
        {
            if(users.Any(x=>x.Login == model.Login && x.Password == model.Password))
            {
                var user = users.FirstOrDefault(x=>x.Login == model.Login && x.Password == model.Password);

                var claims = new List<Claim>
                {
                    new Claim(ClaimsIdentity.DefaultNameClaimType, user.Login)
                    
                };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var token = AuthManager.GenerateToken(claims);

                return new LoginViewModel {Token = token};
            }
            return null;
        }

        public Task GetProfile()
        {
            throw new NotImplementedException();
        }

        public Task<string> Register()
        {
            throw new NotImplementedException();
        }

        public Task<string> Restore()
        {
            throw new NotImplementedException();
        }
    }
}