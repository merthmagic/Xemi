using System;
using Xemi.Core.Configuration;
using Xemi.Core.Dependency;

namespace Xemi.Core
{
    public interface IEngine
    {
        void Initialize(XemiEnvConfig config);

        T Resolve<T>(Type type) where T : class;

        object Resolve(Type type);

        T[] ResolveAll<T>();

        IDependencyManager DependencyManager { get; }
    }
}
