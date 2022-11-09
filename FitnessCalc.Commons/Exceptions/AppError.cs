using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessCalc.Commons.Exceptions
{
    public class AppError
    {
        public string Code { get; set; }
        public string Message { get; set; }
        public AppError(string Message) => this.Message = Message;

        public AppError() {}

    }
}