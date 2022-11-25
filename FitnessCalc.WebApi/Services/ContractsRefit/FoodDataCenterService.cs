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
            var criteria = new List<int> {
                1008,
                1003,
                1004,
                1005  //"Carbohydrate, by difference"
            };
            var result = await _foodDataCenterClient.GetProductFromFoodDataAsync(query, apiKey);
            
            return result.Foods.Select(x => new {
                ExtId = x.FdcId,
                x.ServingSize,
                // x.ServingSizeUnit,
                x.Description,
                x.FoodCategory,
                IdNutrients = x.FoodNutrients
                                .Where(c=> criteria.Contains(c.NutrientId))
                                .Select(n => new {n.NutrientId, n.NutrientName, n.Value, n.UnitName})
                // Nutrients = x.FoodNutrients
                //             .Where(c => c.NutrientName == "Protein").Select(c=> new {c.NutrientName,c.Value})
                            
            });

           //return result.Foods;

        }
    }
}