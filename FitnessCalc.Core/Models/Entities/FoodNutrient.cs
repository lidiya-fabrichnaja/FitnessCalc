using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitnessCalc.Core.Models.Contracts;

namespace FitnessCalc.Core.Models.Entities
{
    public class FoodNutrient : Entity
    {
        public int NutrientId { get; set; }

        public Nutrient Nutrient { get; set; }

        public string? Name { get; set; }

        public double Value { get; set; }  

        public NutrientType? Type { get; set; }

        public int ProductId { get; set; }
        public Product? Product { get; set; }

    }

}