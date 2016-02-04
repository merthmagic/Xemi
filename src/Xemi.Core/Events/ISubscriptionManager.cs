using System.Collections.Generic;

namespace Xemi.Core.Events
{
    public interface ISubscriptionManager
    {
        IList<IConsumer<T>> GetSubscriptions<T>(); 
    }
}