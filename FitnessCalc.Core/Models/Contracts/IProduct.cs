using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitnessCalc.Core.Models.Entities;


namespace FitnessCalc.Core.Models.Contracts
{
    public interface IProduct
    {
        /// <summary>
        /// Белки , g
        /// </summary>
        /// <value></value>
        public double Protein { get; set; }

        /// <summary>
        /// Жиры , g
        /// </summary>
        /// <value></value>
        public double Fat { get; set; }

        /// <summary>
        /// насыщенные жиры , g
        /// </summary>
        /// <value></value>
        public double Fat_saturted { get; set; }

        /// <summary>
        /// транс жиры , g
        /// </summary>
        /// <value></value>
        public double Fat_trans { get; set; }

        /// <summary>
        /// Углеводы , g
        /// </summary>
        /// <value></value>
        public double Carbohydrates { get; set; }
        
        /// <summary>
        /// Кальций , mg
        /// </summary>
        /// <value></value>
        public double Ca { get; set; }

        /// <summary>
        /// Железо , mg
        /// </summary>
        /// <value></value>
        public double Fe { get; set; }

        /// <summary>
        /// Натрий , mg
        /// </summary>
        /// <value></value>
        public double Na { get; set; }

        /// <summary>
        /// Калий , mg
        /// </summary>
        /// <value></value>
        public double K { get; set; }

        /// <summary>
        /// Витамин А
        /// </summary>
        /// <value></value>
        public double Vitamin_A { get; set; }

        /// <summary>
        /// Витамин С , mg
        /// </summary>
        /// <value></value>
        public double Vitamin_C { get; set; }

        /// <summary>
        /// Витамин B6
        /// </summary>
        /// <value></value>
        public double Vitamin_B6 { get; set; }

        /// <summary>
        /// Витамин B12 , µg
        /// </summary>
        /// <value></value>
        public double Vitamin_B12 { get; set; }

        /// <summary>
        /// Витамин D , IU
        /// </summary>
        /// <value></value>
        public double Vitamin_D { get; set; }

        /// <summary>
        /// Магний , mg
        /// </summary>
        /// <value></value>
        public double Mg { get; set; }

        /// <summary>
        /// Сахар , g
        /// </summary>
        /// <value></value>
        public double Sugar { get; set; }   

        /// <summary>
        /// Клетчатка , g
        /// </summary>
        /// <value></value>
        public double Fiber { get; set; }

        /// <summary>
        /// Холестирин , mg
        /// </summary>
        /// <value></value>
        public double Cholesterol { get; set; }

        /// <summary>
        /// Енергетическая ценность , ккал
        /// </summary>
        /// <value></value>
        public double EnergyValue {get;set;}    


    }
}