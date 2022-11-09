using System.Security.Cryptography.X509Certificates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using FluentValidation;

namespace FitnessCalc.App.ViewModels.UserProfile
{
    public class LoginRequest
    {
        [JsonPropertyName("login")]
        public string Login { get; set; }

        [JsonPropertyName("password")]
        public string Password { get; set; }
    }

    public class LoginRequestValidator : AbstractValidator<LoginRequest>
    {
        public LoginRequestValidator()
        {
            RuleFor(x => x.Login)
                .NotEmpty()
                .WithMessage("Не указан логин")
                .NotNull()
                .WithMessage("Не указан логин");

            RuleFor(x => x.Password)
                .NotEmpty()
                .WithMessage("Не указан пароль")
                .NotNull()
                .WithMessage("Не указан пароль");

        }
    }
}