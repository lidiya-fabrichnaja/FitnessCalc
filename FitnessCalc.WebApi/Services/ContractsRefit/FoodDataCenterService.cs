using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitnessCalc.Commons.Options;
using FitnessCalc.WebApi.Models;
using Microsoft.Extensions.Options;

namespace FitnessCalc.WebApi.Services.ContractsRefit
{
    public class FoodDataCenterService
    {
        readonly IFoodDataCenterClient _foodDataCenterClient;
        string apiKey;

        public FoodDataCenterService(IFoodDataCenterClient foodDataCenterClient, IOptions<FoodDataSettings> foodSettings)
        {
            _foodDataCenterClient = foodDataCenterClient;
            apiKey = foodSettings.Value.ApiKey;
        }

        public async Task<object> GetFoodFromDataCenterAsync(string query)
        {
            var result = await _foodDataCenterClient.GetProductFromFoodDataAsync(query, apiKey);
            
            return result.Foods.Select(x => new {
                x.BrandName,
                x.Description,
                x.FoodCategory,
                Nutrients = x.FoodNutrients
                            .Where(c => c.NutrientName == "Protein").Select(c=> new {c.NutrientName,c.Value})});

        }
    }
}