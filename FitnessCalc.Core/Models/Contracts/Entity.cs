using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessCalc.Core.Models.Contracts
{
    public abstract class Entity
    {
        /// <summary>
        /// Внутренний идентификатор
        /// </summary>
        /// <value></value>
        public int Id { get; set; }

        /// <summary>
        /// Внешний идентификатор
        /// </summary>
        /// <value></value>
        public Guid ExtGuid { get; set; }
        
    }
}   