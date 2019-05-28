using System;

namespace ioc_tutorial.Logging
{
    public class LogWebWriter : ILogWriter
    {
        private readonly ILogWriter _logWriter;

        public LogWebWriter(ILogWriter logWriter)
        {
            _logWriter = logWriter;
        }

        public void WriteLine(string message)
        {
            SendToWebClients(message);
            _logWriter.WriteLine(message);
        }

        private void SendToWebClients(string message)
        {
            Console.WriteLine("LogWebWriter::SendToWebClients executed");
            // SENDING TO CLIENTS HAPPENS HERE
        }
    }
}
