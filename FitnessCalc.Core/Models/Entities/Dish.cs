using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitnessCalc.Core.Models.Contracts;

namespace FitnessCalc.Core.Models.Entities
{
    public class Dish : Entity
    {
        public List<Product> Products {get; set;}
    }
}