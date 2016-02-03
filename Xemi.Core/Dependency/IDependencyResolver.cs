using System;

namespace Xemi.Core.Dependency
{
    public interface IDependencyResolver
    {
        T Resolve<T>();

        object Resolve(Type type);

        T[] ResolveAll<T>();

        bool IsRegistered<T>();

        bool IsRegistered(Type type);
    }
}