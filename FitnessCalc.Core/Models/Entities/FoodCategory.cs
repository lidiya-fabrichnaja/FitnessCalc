using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitnessCalc.Core.Models.Contracts;

namespace FitnessCalc.Core.Models.Entities
{
    public class FoodCategory : Entity
    {
        public string? Name { get; set; }
    }
}