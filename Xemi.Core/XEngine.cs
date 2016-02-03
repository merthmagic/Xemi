using System;
using Xemi.Core.Configuration;
using Xemi.Core.Dependency;

namespace Xemi.Core
{
    public class XEngine:IEngine
    {
        private readonly IDependencyManager _dependencyManager;

        public XEngine()
        {
            _dependencyManager = EngineContext.DependencyManager;
        }

        public void Initialize(XemiEnvConfig config)
        {
            InitializeModules();

            if (!config.IgnoreStartupTasks)
                RunStartupTasks();
        }

        public T Resolve<T>(Type type) where T : class
        {
            return _dependencyManager.Resolve<T>();
        }

        public object Resolve(Type type)
        {
            return _dependencyManager.Resolve(type);
        }

        public T[] ResolveAll<T>()
        {
            return _dependencyManager.ResolveAll<T>();
        }

        protected void RunStartupTasks()
        {
            //TODO:
        }

        protected void InitializeModules()
        {
            //TODO:
        }

        public IDependencyManager DependencyManager
        {
            get { return _dependencyManager; }
        }
    }
}