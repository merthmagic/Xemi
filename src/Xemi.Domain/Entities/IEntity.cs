namespace Xemi.Domain.Entities
{

    public interface IEntity<TKey>
    {
        TKey Id { get; }

        bool IsTransient();
    }

    public interface IEntity : IEntity<int>
    {
        
    }
}