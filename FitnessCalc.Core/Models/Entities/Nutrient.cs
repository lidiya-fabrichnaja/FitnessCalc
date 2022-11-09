using FitnessCalc.Core.Models.Contracts;

namespace FitnessCalc.Core.Models.Entities
{
    public class Nutrient : Entity
    {
        public int ExtId { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public string Unit { get; set; }

        public virtual List<FoodNutrient> FoodNutrients { get; set; }

    }
}