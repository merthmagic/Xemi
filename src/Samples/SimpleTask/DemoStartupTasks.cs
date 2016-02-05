using System;
using Xemi.Core.Tasks;

namespace SimpleTask
{
    public class GreetingStartupTask : IStartupTask
    {
        public void Execute()
        {
            Console.WriteLine("Greeting Info...");
        }

        public int Order
        {
            get { return 1; }
        }
    }
}