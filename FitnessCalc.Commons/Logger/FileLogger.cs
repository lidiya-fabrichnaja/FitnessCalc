using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace FitnessCalc.Commons.Logger
{
    public class FileLogger : ILogger, IDisposable
    {
        string _path;
        static object _lock = new();

        public FileLogger(string path)
        {
            _path = path;

        }

        public IDisposable BeginScope<TState>(TState state)
        {
            return this;
        }

        public void Dispose(){}

        public bool IsEnabled(LogLevel logLevel)
        {
            return true;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId,
                    TState state, Exception? exception, Func<TState, Exception?, string> formatter)
        {
            lock(_lock)
            {
                File.AppendAllText(_path, formatter(state, exception) + Environment.NewLine);
            }
        }            
    }
}