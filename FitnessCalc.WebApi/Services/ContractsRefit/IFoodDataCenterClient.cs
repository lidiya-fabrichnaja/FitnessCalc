using System.Dynamic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitnessCalc.WebApi.Models;
using Refit;

namespace FitnessCalc.WebApi.Services.ContractsRefit
{
    public interface IFoodDataCenterClient
    {
        [Get("fdc/v1/foods/search?query={query}&api_key=vZnVspII9x9VLAdowiMHZI8ndKbDXmG4bIpPLs9Z")]
        Task<FoodData> GetProductFromFoodDataAsync(string query, string apiKey);

    }
}