using System;
using Xemi.Core.Dependency;
using Autofac;

namespace Xemi.Dependency.Autofac
{
    public class DependencyManager : IDependencyManager
    {
        private ContainerManager _containerManager;

        public DependencyManager()
        {
            IntializeContainer();
        }

        private void IntializeContainer()
        {
            var container = new ContainerBuilder();
            _containerManager = new ContainerManager(container.Build());
            ContainerConfigure(_containerManager);
        }

        private void ContainerConfigure(ContainerManager containerManager)
        {
            //TODO:
        }

        public T Resolve<T>() where T : class
        {
            return _containerManager.Resolve<T>();
        }

        public object Resolve(Type type)
        {
            return _containerManager.Resolve(type);
        }

        public T[] ResolveAll<T>()
        {
            return _containerManager.ResolveAll<T>();
        }

        public bool IsRegistered<T>() where T : class
        {
            return _containerManager.IsRegistered<T>();
        }

        public bool IsRegistered(Type type)
        {
            return _containerManager.IsRegistered(type);
        }

        public void Register<T>(DependencyLifeStyle dependencyLifeStyle = DependencyLifeStyle.Singleton) where T : class
        {
            _containerManager.AddComponent<T>(lifeStyle: dependencyLifeStyle.ToComponentLifeStyle());
        }

        public void Register(Type type, DependencyLifeStyle dependencyLifeStyle = DependencyLifeStyle.Singleton)
        {
            _containerManager.AddComponent(type, lifeStyle: dependencyLifeStyle.ToComponentLifeStyle());
        }

        public void Register<TType, TImpl>(DependencyLifeStyle dependencyLifeStyle = DependencyLifeStyle.Singleton)
            where TType : class
            where TImpl : class
        {
            _containerManager.AddComponent<TType, TImpl>(lifeStyle: dependencyLifeStyle.ToComponentLifeStyle());
        }

        public void Register(Type type, Type typeImpl, DependencyLifeStyle dependencyLifeStyle = DependencyLifeStyle.Singleton)
        {
            _containerManager.AddComponent(type, typeImpl, lifeStyle: dependencyLifeStyle.ToComponentLifeStyle());
        }

        public void RegisterGeneric(Type implementer)
        {
            _containerManager.AddGenericComponent(implementer);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}