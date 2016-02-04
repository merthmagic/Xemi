using Xemi.Core.Dependency;

namespace Xemi.Core.Modules
{
    public abstract class XModule:IModule
    {
        public virtual void Initialize()
        {
            
        }

        public IDependencyManager DependencyManager
        {
            get { return EngineContext.Current.DependencyManager; }
        }
    }
}