using ioc_tutorial.Config;
using System;
using System.IO;

namespace ioc_tutorial.Logging
{
    public class LogWriter : ILogWriter
    {
        private readonly string _logFilePath;

        public LogWriter(string logFilePath)
        {
            _logFilePath = logFilePath;
        }

        public void WriteLine(string message)
        {
            Console.WriteLine($"LogWriter:: {message}");
            
            using (var logFileWriter = File.AppendText(_logFilePath))
            {
                logFileWriter.Write($"{message}/r/n");
            }
        }
    }
}
