using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FitnessCalc.App.ViewModels.UserProfile;
using Microsoft.AspNetCore.Authorization;
using FitnessCalc.App.Services.UserService;
using FitnessCalc.Commons.BaseObjects;
using FitnessCalc.Commons.Exceptions;

namespace FitnessCalc.WebApi.Controllers.V1
{
    [ApiVersion("1.0")]
    public class ProfileController : BaseController
    {
        readonly IUserService _service;
        
        public ProfileController(IUserService service)
        {
            _service = service; 
        }

        [HttpPost("Auth")]
        [AllowAnonymous]
        public async Task<IActionResult> Auth(LoginRequest model)
        {
            AppResponce<LoginViewModel> result;
            
            var data = await _service.Auth(model);

            if(data == null) 
                result = new AppResponce<LoginViewModel>(new AppError("Не верный логин или пароль"));
            else
                result = new AppResponce<LoginViewModel>(data);

           
            return Ok(result);

            // if(result != null) 
            //     return Ok(result);

            // return Unauthorized();
        }
    }
}