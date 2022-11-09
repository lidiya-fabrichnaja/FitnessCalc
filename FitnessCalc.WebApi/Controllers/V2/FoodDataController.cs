using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitnessCalc.WebApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace FitnessCalc.WebApi.Controllers.V2
{
    [ApiVersion("2.0")]
    public class FoodDataController : BaseController
    {
        private FoodDataService _service;

        public FoodDataController(FoodDataService service)
        {
            _service = service;   
        }

        [HttpGet(Name = "GetFoodData")]
        public async Task<IActionResult> Get(string query)
        {
            var result = await _service.GetProductFromFoodDataAsync(query);
            return Ok(result);
        }
    }
}