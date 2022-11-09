using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using FitnessCalc.Commons.Exceptions;

namespace FitnessCalc.Commons.BaseObjects
{
    public class AppResponce
    {
        readonly bool _success;
        readonly IEnumerable<AppError> _errors = new AppError[0];

        readonly string _message;

        public AppResponce() => _success = true;

        public AppResponce(IEnumerable<AppError> errors)
        {
            _success = false;
            _errors = errors;
        }

        public AppResponce(AppError error)
        {
            _success = false;
            _errors = new AppError[] { error };
        }

        public AppResponce(string message)
        {
            _success = true;
            _message = message;
        }
        
        [JsonPropertyName("success")]
        public bool Success => _success;

        [JsonPropertyName("errors")]
        public IEnumerable<AppError> Errors => _errors;

        [JsonPropertyName("message")]
        public string Message => _message;

    }

    public class AppResponce<T> : AppResponce
    {
        readonly T _data;

        public AppResponce(T data) : base()
        {
            _data = data;
        }
        public AppResponce(AppError error) : base(error)
        {
            
        }

        public AppResponce(IEnumerable<AppError> errors) : base(errors)
        {
            
        }

        [JsonPropertyName("data")]
        public T Data => _data;
    }
}