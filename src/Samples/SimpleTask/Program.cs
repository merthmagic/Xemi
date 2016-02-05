using System;
using Xemi.Core;
using Xemi.Core.Logging;

namespace SimpleTask
{
    class Program
    {
        static void Main(string[] args)
        {
            EngineContext.Initialize();

            var engine = EngineContext.Current;

            var logger = engine.Resolve<ILogger>(typeof (ILogger));

            logger.Info("Info message","");

            Console.ReadKey(true);
        }
    }
}
