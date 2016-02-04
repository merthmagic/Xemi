using System.Collections.Generic;

namespace Xemi.Core.Events
{
    public interface IConsumerFinder
    {
        ICollection<IConsumer<T>> FindConsumers<T>();
    }
}