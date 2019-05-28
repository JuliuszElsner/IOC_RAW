using ioc_tutorial.Logging;
using System;

namespace ioc_tutorial.Server
{
    public class LogServer : IServer
    {
        public string ServerId { get; }
        private readonly ILogWriter _logWriter;
        
        public LogServer(ILogWriter logWriter)
        {
            _logWriter = logWriter;
            ServerId = $"SER_{DateTime.UtcNow.ToString()}_WER";
        }

        public void StartOperating()
        {
            _logWriter.WriteLine("Server has been started.");
        }

        public void StopOperating()
        {
            // SUPER STOP_OPERATING LOGIC
            // LOGIC
            // LOGIC
            // THIS SHOULD NOT HAPPEN
        }
    }
}
