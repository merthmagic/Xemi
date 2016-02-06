namespace Xemi.Domain.Entities
{

    public interface IEntity<out TKey>
    {
        TKey Id { get; }
    }

    public interface IEntity : IEntity<int>
    {
        
    }
}