using System;
using System.Linq;
using Xemi.Core.Configuration;
using Xemi.Core.Dependency;
using Xemi.Core.Reflection;
using Xemi.Core.Tasks;

namespace Xemi.Core
{
    public class XEngine : IEngine
    {
        private readonly IDependencyManager _dependencyManager;

        public XEngine()
        {
            _dependencyManager = EngineContext.DependencyManager;
        }

        public void Initialize(XemiEnvConfig config)
        {
            InternalInitalize(config);

            InitializeModules();

            if (!config.IgnoreStartupTasks)
                RunStartupTasks();
        }

        private void InternalInitalize(XemiEnvConfig config)
        {
            VerifyContext();

            RegisterCoreDependencies();
        }

        private void VerifyContext()
        {
            if (_dependencyManager == null)
                throw new XemiException("Intialize engine failed because denpendency manager provided by context is null");
        }

        private void RegisterCoreDependencies()
        {
            //Some core dependencies are registerd in this method
            //FIXME: hard code exits here(register AppDomainTypeFinder for testing).
            _dependencyManager.Register<ITypeFinder, AppDomainTypeFinder>();
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
            var typeFinder = DependencyManager.Resolve<ITypeFinder>();
            var tasks = typeFinder.FindClassesOfType<IStartupTask>()
                .Select(p => (IStartupTask)Activator.CreateInstance(p)).ToList().OrderBy(q => q.Order); ;
            foreach (var task in tasks)
            {
                task.Execute();
            }
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