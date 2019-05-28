using System;

namespace ioc_tutorial.Server.Redundancy
{
    public class ServerRedundancy
    {
        public TimeSpan ServerTimeout { get; set; }
        public int ConnectionRetryLimit { get; set; }
    }
}
