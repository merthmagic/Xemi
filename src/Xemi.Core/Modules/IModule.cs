using Xemi.Core.Dependency;

namespace Xemi.Core.Modules
{
    public interface IModule:IDependencyManagerContainer
    {
        void Initialize();
    }
}