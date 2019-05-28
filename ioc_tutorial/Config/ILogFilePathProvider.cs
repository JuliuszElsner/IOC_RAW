using System;
using System.Collections.Generic;
using System.Text;

namespace ioc_tutorial.Config
{
    public interface ILogFilePathProvider
    {
        string GetLogFilePath();
    }
}
