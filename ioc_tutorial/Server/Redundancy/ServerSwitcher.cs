namespace ioc_tutorial.Server.Redundancy
{
    public class ServerSwitcher : IServerSwitcher
    {
        public IServer PrimaryServer { get; set; }
        public IServer SecondaryServer { get; set; }
        public IServer TertiaryServer { get; set; }

        private readonly ServerRedundancy _serverRedundancy;

        public ServerSwitcher(ServerRedundancy a_serverRedundancy)
        {
            _serverRedundancy = a_serverRedundancy;
        }

        public void ProcessingLoop()
        {
            PrimaryServer?.StartOperating();
            SecondaryServer?.StartOperating();
            TertiaryServer?.StartOperating();
            // LOGIC
            // super server switching
            // super się przełączam miedzy serwerami hah ha ha hi hi
        }
    }
}
