using System;
using System.IO;

namespace ioc_tutorial.Logging
{
    public class ExtendedLogWriter : ILogWriter
    {
        private readonly string _logFilePath;

        public ExtendedLogWriter(string logFilePath)
        {
            _logFilePath = logFilePath;
        }

        public void WriteLine(string message)
        {
            Console.WriteLine("ExtendedLogWriter::WriteLine executed");
            using (var logFileWriter = File.AppendText(_logFilePath))
            {
                logFileWriter.Write($"{DateTime.UtcNow} : {message}/r/n");
            }
        }
    }
}
