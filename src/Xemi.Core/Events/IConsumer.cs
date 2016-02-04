namespace Xemi.Core.Events
{
    public interface IConsumer<in T>
    {
        void HandleEvent(T eventMessage);
    }
}