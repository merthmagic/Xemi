namespace Xemi.Core.Logging
{
    public class NullLogger:ILogger
    {
        public void InsertLog(LogLevel logLevel, string shortMessage, string fullMessage = "", string userIdentifier = "")
        {
            
        }
    }
}