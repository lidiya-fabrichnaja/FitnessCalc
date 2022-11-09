using FitnessCalc.Core.Models.Contracts;

namespace FitnessCalc.Core.Models.Entities
{
    public class User : Entity
    {
        public string? Surname { get; set; }
        public string? Name { get; set; }
        public string? Patronymic { get; set; }

        public List<Ingestion> ProductStorage { get; set; } = new List<Ingestion>(1);


    }
}