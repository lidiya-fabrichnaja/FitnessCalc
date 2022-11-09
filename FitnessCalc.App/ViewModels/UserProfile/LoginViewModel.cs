using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FitnessCalc.App.ViewModels.UserProfile
{
    public class LoginViewModel
    {
        [JsonPropertyName("token")]
        public string Token { get; set; }
    }
}