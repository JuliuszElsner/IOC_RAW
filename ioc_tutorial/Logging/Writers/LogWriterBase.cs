using System;
using System.IO;

namespace ioc_tutorial.Logging
{
    public abstract class LogWriterBase : ILogWriter
    {
        protected readonly FileStream _logFile;

        public LogWriterBase(string logFilePath)
        {
            Console.WriteLine("Open handle to logFile");
            _logFile = File.Open(logFilePath, FileMode.Append, FileAccess.Write);
        }

        public abstract void WriteLine(string message);
    }
}
