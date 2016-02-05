using System;
using Xemi.Core;
using Xemi.Core.Logging;
using Xemi.Core.Modules;

namespace SimpleTask
{
    public class SimpleLogger:ILogger
    {
        public void InsertLog(LogLevel logLevel, string shortMessage, string fullMessage = "", string userIdentifier = "")
        {
            Console.WriteLine("[{0}] - {1}", logLevel, shortMessage);
        }
    }

    public class LoggingModule : XModule
    {
        public override void Initialize()
        {
            EngineContext.Current.DependencyManager.Register<ILogger,SimpleLogger>();
        }
    }
}