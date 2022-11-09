using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace FitnessCalc.WebApi.Controllers
{
    [ApiController]
    [DisableCors] //TODO CORS
    [Authorize]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class BaseController : ControllerBase
    {
        
    }
}