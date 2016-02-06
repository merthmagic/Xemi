namespace Xemi.Domain
{

    public interface IEntity<out TKey>
    {
        TKey Id { get; }
    }

    public interface IEntity : IEntity<int>
    {
        
    }
}