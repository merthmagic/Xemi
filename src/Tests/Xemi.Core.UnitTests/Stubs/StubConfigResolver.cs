using Xemi.Core.Configuration;

namespace Xemi.Core.UnitTests.Stubs
{
    public class StubConfigResolver : IConfigResolver
    {
        private readonly bool _ignoreStartupTask;

        public StubConfigResolver(bool ignoreStartupTasks = true)
        {
            _ignoreStartupTask = ignoreStartupTasks;
        }


        public string GetConfig(string key)
        {
            switch (key)
            {
                case "Xemi:DependencyManagerType":
                    {
                        return "Xemi.Dependency.Autofac.DependencyManager,Xemi.Dependency.Autofac";
                    }
                case "Xemi:IgnoreStartupTasks":
                    {
                        return _ignoreStartupTask.ToString();
                    }
                default:
                    {
                        return null;
                    }
            }
        }
    }
}