namespace Xemi.Core.Logging
{
    public interface ILogger
    {
        void InsertLog(LogLevel logLevel, string shortMessage, string fullMessage = "", string userIdentifier = "");
    }
}