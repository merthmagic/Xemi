using Xemi.Domain.Entities;

namespace Xemi.Domain.Repository
{
    public interface IRepository<TEntity> : 
        IRepository<TEntity, int> where TEntity : class,IEntity<int>
    {

    }
}