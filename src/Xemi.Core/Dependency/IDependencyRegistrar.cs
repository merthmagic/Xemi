using System;

namespace Xemi.Core.Dependency
{
    public interface IDependencyRegistrar
    {
        void Register<T>(DependencyLifeStyle dependencyLifeStyle = DependencyLifeStyle.Singleton) 
            where T : class;

        void Register(Type type, DependencyLifeStyle dependencyLifeStyle = DependencyLifeStyle.Singleton);

        void Register<TType, TImpl>(DependencyLifeStyle dependencyLifeStyle = DependencyLifeStyle.Singleton)
            where TType : class
            where TImpl : class;

        void Register(Type type, Type typeImpl, DependencyLifeStyle dependencyLifeStyle = DependencyLifeStyle.Singleton);

        //Register generic types is planed to be supported.
        //But it may coz some problem if put this feature here, due to some 3rd party IoC components may not support this operation.
        //So, this method may be removed from this interface and added in extension method in the future.
        void RegisterGeneric(Type implementer);
    }
}