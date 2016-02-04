using Xemi.Core.Tasks;

namespace Xemi.Core.UnitTests.Stubs
{
    public class StubTask:IStartupTask
    {
        public void Execute()
        {
            throw new TestingExpectedException();
        }

        public int Order { get { return 1; } }
    }
}