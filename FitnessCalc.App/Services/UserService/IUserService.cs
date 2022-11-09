using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitnessCalc.App.ViewModels.UserProfile;

namespace FitnessCalc.App.Services.UserService
{
    public interface IUserService
    {
        Task<string> Register();
        Task<LoginViewModel> Auth(LoginRequest model);
        Task<string> Restore();
        Task GetProfile();
    }
}