using Xemi.Core.Modules;

namespace Xemi.Core.UnitTests.Stubs
{
    public class StubModule:XModule
    {
        public override void Initialize()
        {
            Output = "Initialized";
        }

        public static string Output { get; set; }
    }
}