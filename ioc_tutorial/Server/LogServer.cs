using DatabaseLib.UsersStorage;
using ioc_tutorial.Logging;
using System;

namespace ioc_tutorial.Server
{
    public class LogServer : IServer
    {
        public string ServerId { get; }
        private readonly ILogWriter _logWriter;
        private readonly IUsers _usersSource;
        private readonly IUserPreferences _userPreferences;
        
        public LogServer(ILogWriter logWriter, IUsers usersSource, IUserPreferences userPreferences)
        {
            _logWriter = logWriter;
            _usersSource = usersSource;
            _userPreferences = userPreferences;
            ServerId = $"SER_{DateTime.UtcNow.ToString()}_WER";
        }

        public void StartOperating()
        {
            _logWriter.WriteLine("Server has been started.");

            foreach(var user in _usersSource.GetAllUsers())
            {
                _logWriter.WriteLine($"{user.Name } = mierzy {user.Height} a lubi {_userPreferences.GetUserPreference(user.Id)}");
            }
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
