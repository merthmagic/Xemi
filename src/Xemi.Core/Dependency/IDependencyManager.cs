using System;

namespace Xemi.Core.Dependency
{
    public interface IDependencyManager:IDependencyResolver,IDependencyRegistrar,IDisposable
    {
         
    }
}