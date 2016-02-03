using Xemi.Core.Configuration;

namespace Xemi.Core.UnitTests.Stubs
{
    public class StubConfigResolver : IConfigResolver
    {
        public string GetConfig(string key)
        {
            switch (key)
            {
                case "Xemi:DependencyManagerType":
                    {
                        return "Xemi.Dependency.Autofac.DependencyManager,Xemi.Dependency.Autofac";
                    }
                default:
                    {
                        return null;
                    }
            }
        }
    }
}