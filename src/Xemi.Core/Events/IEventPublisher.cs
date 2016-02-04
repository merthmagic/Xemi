namespace Xemi.Core.Events
{
    public interface IEventPublisher
    {
        void Publish<T>(T eventMessage); 
    }
}