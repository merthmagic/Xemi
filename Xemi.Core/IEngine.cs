using System;
using Xemi.Core.Configuration;

namespace Xemi.Core
{
    public interface IEngine
    {
        void Initialize(XemiEnvConfig config);

        T Resolve<T>(Type type) where T : class;

        object Resolve(Type type);

        T[] ResolveAll<T>();
    }
}
