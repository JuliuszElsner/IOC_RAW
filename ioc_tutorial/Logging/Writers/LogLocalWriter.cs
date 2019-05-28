using System;

namespace ioc_tutorial.Logging
{
    public class LogLocalWriter : ILogWriter
    {
        private readonly ILogWriter _logWriter;

        public LogLocalWriter(ILogWriter logWriter)
        {
            _logWriter = logWriter;
        }

        public void WriteLine(string message)
        {
            SendToAllClients(message);
            _logWriter.WriteLine(message);
        }

        private void SendToAllClients(string message)
        {
            Console.WriteLine("LogLocalWriter::SendToAllClients executed");
            // SENDING TO CLIENTS HAPPENS HERE
        }
    }
}
