using Xemi.Core.Dependency;

namespace Xemi.Dependency.Autofac
{
    public static class Extensions
    {
        public static ComponentLifeStyle ToComponentLifeStyle(this DependencyLifeStyle lifeStyle)
        {
            switch (lifeStyle)
            {
                case DependencyLifeStyle.Singleton:
                    return ComponentLifeStyle.Singleton;
                case DependencyLifeStyle.Transient:
                    return ComponentLifeStyle.Transient;
                default:
                    return ComponentLifeStyle.LifetimeScope;
            }
        }
    }
}