using System.Reflection.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AutoMapper;
using FitnessCalc.Core.Models.Entities;

namespace FitnessCalc.App.ViewModels
{
    public class ProductViewModel : BaseViewModel
    {
        public string Name { get; set; }

        public double EnergyValue { get; set; }

        public List<FoodNutrient> Nutrients { get; set;}
    }


    public class ProductViewModelMapper : Profile
    {
        ProductViewModelMapper()
        {
            CreateMap<Product,ProductViewModel>();
        }
    }
}