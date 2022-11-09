using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessCalc.Commons.Options
{
    public class ApiSettings
    {
        public List<ApiKey> ApiKeys {get; set;}
    }

    public class ApiKey
    {
        public string Name { get; private set; }
        public string Value { get; private set; }
    }
}