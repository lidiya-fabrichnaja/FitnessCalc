using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitnessCalc.WebApi.Services;
using FitnessCalc.WebApi.Services.ContractsRefit;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FitnessCalc.WebApi.Controllers.V2
{
    [ApiVersion("2.0")]
    public class FoodDataController : BaseController
    {
        private FoodDataCenterService _service;

        public FoodDataController(FoodDataCenterService service)
        {
            _service = service;   
        }

        [AllowAnonymous]
        [HttpGet(Name = "GetFoodData")]
        public async Task<IActionResult> Get(string query)
        {
            var result = await _service.GetFoodFromDataCenterAsync(query);
            return Ok(result);
        }
    }
}