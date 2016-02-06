namespace Xemi.Domain.Entities
{
    public interface ISoftDelete
    {
        bool IsDeleted { get; } 
    }
}