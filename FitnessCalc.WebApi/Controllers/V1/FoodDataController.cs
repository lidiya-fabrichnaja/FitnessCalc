using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitnessCalc.Commons.BaseObjects;
using FitnessCalc.WebApi.Models;
using FitnessCalc.WebApi.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FitnessCalc.WebApi.Controllers.V1
{
    [ApiVersion("1.0")]
    public class FoodDataController : BaseController
    {
        private FoodDataService _service;

        public FoodDataController(FoodDataService service)
        {
            _service = service;   
        }

        //[Authorize]
        [AllowAnonymous]
        [HttpGet(Name = "GetFoodData")]
        //[ProducesResponseType(typeof(AppResponce<FoodData>), 200)]
        public async Task<IActionResult> Get(string query)
        {
            var result = await _service.GetProductFromFoodDataAsync(query);
            return Ok(result);
        }
    }
}