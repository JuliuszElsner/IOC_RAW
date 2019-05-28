using ioc_tutorial.Config;
using System;
using System.IO;

namespace ioc_tutorial.Logging
{
    public class LogWriter : LogWriterBase
    {
        public LogWriter(string logFilePath) : base(logFilePath)
        {
        }

        public LogWriter(Configuration configuration) : base(configuration.LogFilePath)
        {
        }

        public override void WriteLine(string message)
        {
            Console.WriteLine("LogWriter::WriteLine executed");
            using (var logFileWriter = new StreamWriter(_logFile))
            {
                logFileWriter.Write($"{message}/r/n");
            }
        }
    }
}
