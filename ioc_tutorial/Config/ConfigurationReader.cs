using ioc_tutorial.Server.Redundancy;
using System;

namespace ioc_tutorial.Config
{
    public class ConfigurationReader : IConfigurationReader
    {
        private readonly string _configFilePath;

        public IConfiguration Read()
        {
            return new Configuration
            {
                LogFilePath = "D://temp//log.tx",
                Name = "AutoFacTest" ,
                ServerRedundancy = new ServerRedundancy { ConnectionRetryLimit = 3, ServerTimeout = TimeSpan.FromSeconds(20)}
            };
        }
    }
}
