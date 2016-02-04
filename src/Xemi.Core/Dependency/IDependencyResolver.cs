using System;

namespace Xemi.Core.Dependency
{
    public interface IDependencyResolver
    {
        T Resolve<T>() where T:class;

        object Resolve(Type type);

        T[] ResolveAll<T>();

        bool IsRegistered<T>() where T:class;

        bool IsRegistered(Type type);
    }
}