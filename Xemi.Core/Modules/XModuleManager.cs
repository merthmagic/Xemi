using System;
using System.Linq;
using Xemi.Core.Reflection;

namespace Xemi.Core.Modules
{
    public class XModuleManager:IModuleManager
    {
        private readonly ITypeFinder _typeFinder;

        public XModuleManager(ITypeFinder typeFinder)
        {
            _typeFinder = typeFinder;
        }

        public void IntializeModules()
        {
            //FIXME: it is not a good solution to initialzie modules
            //since maybe some modules depende on other modules
            //a possible better solution is register all the module types to DI manger
            //and then to initalize them. It requires more invesitigation.
            var moduleTypes = _typeFinder.FindClassesOfType<IModule>();
            foreach (var module in moduleTypes.Select(type => Activator.CreateInstance(type) as IModule))
            {
                module.Initialize();
            }
        }
    }
}