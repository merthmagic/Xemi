using System.Linq;
using Xemi.Core.Reflection;

namespace Xemi.Core.Events
{
    //publish and subscribe all are sync operations in this impl
    public class XEventPublisher:IEventPublisher
    {
        private readonly ISubscriptionManager _subscriptionManager;
        private readonly IConsumerFinder _consumerFinder;

        public XEventPublisher(ISubscriptionManager subscriptionManager,IConsumerFinder consumerFinder)
        {
            _subscriptionManager = subscriptionManager;
            _consumerFinder = consumerFinder;
        }

        public void Publish<T>(T eventMessage)
        {
            var subscriptions = _subscriptionManager.GetSubscriptions<T>();
            subscriptions.ToList().ForEach(x=>PublishToConsumer(x,eventMessage));
        }

        protected virtual void PublishToConsumer<T>(IConsumer<T> consumer, T eventMessage)
        {
            var consumers = _consumerFinder.FindConsumers<T>();
            consumers.ToList().ForEach(x=>x.HandleEvent(eventMessage));
        }
    }
}