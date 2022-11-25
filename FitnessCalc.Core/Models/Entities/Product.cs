using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitnessCalc.Core.Models.Contracts;

namespace FitnessCalc.Core.Models.Entities
{
    /// <summary>
    /// 100 g продукта
    /// </summary>
    public class Product : Entity
    {
        public string Name { get; set; }

        public double EnergyValue { get; set; }

        public List<FoodNutrient> Nutrients { get; set; } = new List<FoodNutrient>(1);

        public int FoodCategoryId { get; set; }

        public FoodCategory FoodCategory { get; set; }

      
    }
}