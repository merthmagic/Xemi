using Xemi.Core.Utils;

namespace Xemi.Core.Configuration
{
    public class XemiEnvConfig
    {
        private readonly IConfigResolver _resolver;

        private const string ENGINE_TYPE_CONFIG_KEY = "Xemi:EngineType";

        private const string DEFAULT_ENGINE_TYPE = "Xemi.Core.XEngine";

        private const string IGNORE_STARTUP_TASKS_CONFIG_KEY = "Xemi:IgnoreStartupTasks";

        private const string DEPENDENCY_TYPE_CONFIG_KEY = "Xemi:DependencyManagerType";

        public XemiEnvConfig()
        {
            _resolver = ConfigResolver.Current;
        }

        public string EngineType
        {
            get
            {
                return _resolver.GetConfig(ENGINE_TYPE_CONFIG_KEY).GetValueOrDefault(DEFAULT_ENGINE_TYPE);
            }
        }

        public bool IgnoreStartupTasks
        {
            get
            {
                return _resolver.GetConfig(IGNORE_STARTUP_TASKS_CONFIG_KEY).GetValueOrDefault("False") == bool.TrueString;
            }
        }

        public string DependencyManagerType
        {
            get { return _resolver.GetConfig(DEPENDENCY_TYPE_CONFIG_KEY); }
        }
    }
}