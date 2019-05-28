using System;
using System.IO;

namespace ioc_tutorial.Logging
{
    public class ExtendedLogWriter : LogWriterBase
    {
        public ExtendedLogWriter(string logFilePath) : base(logFilePath)
        {
        }

        public override void WriteLine(string message)
        {
            Console.WriteLine("ExtendedLogWriter::WriteLine executed");
            using (var logFileWriter = new StreamWriter(_logFile))
            {
                logFileWriter.Write($"{DateTime.UtcNow} : {message}/r/n");
            }
        }
    }
}
