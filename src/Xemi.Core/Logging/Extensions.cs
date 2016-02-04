namespace Xemi.Core.Logging
{
    public static class Extensions
    {
        public static void Debug(this ILogger logger, string message, string userIdentifier)
        {
            logger.InsertLog(LogLevel.Debug, message, userIdentifier: userIdentifier);
        }

        public static void Info(this ILogger logger, string message, string userIdentifier)
        {
            logger.InsertLog(LogLevel.Info, message, userIdentifier: userIdentifier);
        }

        public static void Warning(this ILogger logger, string message, string userIdentifier)
        {
            logger.InsertLog(LogLevel.Warn, message, userIdentifier: userIdentifier);
        }

        public static void Error(this ILogger logger, string message, string userIdentifier)
        {
            logger.InsertLog(LogLevel.Error, message, userIdentifier: userIdentifier);
        }

        public static void Fatal(this ILogger logger, string message, string userIdentifier)
        {
            logger.InsertLog(LogLevel.Fatal, message, userIdentifier: userIdentifier);
        }
    }
}