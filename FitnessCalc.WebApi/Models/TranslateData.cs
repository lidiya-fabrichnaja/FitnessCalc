using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessCalc.WebApi.Models
{
    public class TranslateData
    {
        public int code { get; set; }
        public string lang { get; set; }
        public List<string> text { get; set; }
        public string message { get; set; }
    }
}