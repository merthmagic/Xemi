using Xemi.Core.Dependency;

namespace Xemi.Dependency.Autofac
{
    public class DependencyManager:IDependencyManager
    {
        public T Resolve<T>()
        {
            throw new System.NotImplementedException();
        }

        public object Resolve(System.Type type)
        {
            throw new System.NotImplementedException();
        }

        public T[] ResolveAll<T>()
        {
            throw new System.NotImplementedException();
        }

        public bool IsRegistered<T>()
        {
            throw new System.NotImplementedException();
        }

        public bool IsRegistered(System.Type type)
        {
            throw new System.NotImplementedException();
        }

        public void Register<T>(DependencyLifeStyle dependencyLifeStyle = DependencyLifeStyle.Singleton) where T : class
        {
            throw new System.NotImplementedException();
        }

        public void Register(System.Type type, DependencyLifeStyle dependencyLifeStyle = DependencyLifeStyle.Singleton)
        {
            throw new System.NotImplementedException();
        }

        public void Register<TType, TImpl>(DependencyLifeStyle dependencyLifeStyle = DependencyLifeStyle.Singleton)
            where TType : class
            where TImpl : class
        {
            throw new System.NotImplementedException();
        }

        public void Register(System.Type type, System.Type typeImpl, DependencyLifeStyle dependencyLifeStyle = DependencyLifeStyle.Singleton)
        {
            throw new System.NotImplementedException();
        }

        public void RegisterGeneric(System.Type implementer)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }
    }
}