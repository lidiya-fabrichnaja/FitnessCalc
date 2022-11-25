using System.Runtime.InteropServices.ComTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using FitnessCalc.Commons.Options;
using FitnessCalc.WebApi.Models;
using Microsoft.Extensions.Options;

namespace FitnessCalc.WebApi.Services
{
    public class FoodDataService
    {
        readonly IHttpClientFactory _httpClientFactory;
  
        string apiKey;

        public FoodDataService(IHttpClientFactory httpClientFactory, IOptions<FoodDataSettings> foodSettings)
        {
            _httpClientFactory = httpClientFactory;
                     
            apiKey = foodSettings.Value.ApiKey;

        }

       
        
        string dataType = "SR Legacy";//"SR Legacy, Branded , Survey (FNDDS) , Fundation";
        string sortBy = "dataType.keyword";
        string sortOrder = "asc";
        string requireAllWords = "true";

        // string pageSize = "100";

        // string pageNumber = "1";
    
        
        public async Task<object> GetProductFromFoodDataAsync(string query)
        {
            var httpRequestMessage = 
                $"fdc/v1/foods/search?query={query}" +
                 $"&dataType={dataType}&sortBy={sortBy}&sortOrder={sortOrder}&api_key={apiKey}"
         ;

            var httpClient = _httpClientFactory.CreateClient("FoodDataCenter");
            var httpResponseMessage = await httpClient.GetAsync(httpRequestMessage);

            httpResponseMessage.EnsureSuccessStatusCode();

            var response = await httpResponseMessage.Content.ReadFromJsonAsync<FoodData>();
            
            return response.Foods.Select(x => new {
                x.BrandName,
                x.Description,
                x.FoodCategory,
                Nutrients = x.FoodNutrients
                            .Where(c => c.NutrientName == "Protein").Select(c=> new {c.NutrientName,c.Value})});

            //return response ?? new FoodData();
        }
    }


  
    
   
}