using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitnessCalc.Core.Models.Contracts;

namespace FitnessCalc.Core.Models.Entities
{
    /// <summary>
    /// Прием пищи . табл пользователь.продукт
    /// </summary>
    public class Ingestion : Entity
    {
        public int UserId { get; set; }
        public User User { get; set; }

        public int ProductId { get; set; } 

        public List<Product> Product {get; set;} 

        public DateTime Date { get; set; }

        public IngestionType Type { get; set; }






    }
}