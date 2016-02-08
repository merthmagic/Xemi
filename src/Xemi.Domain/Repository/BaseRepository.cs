using Xemi.Domain.Entities;

namespace Xemi.Domain.Repository
{
    public abstract class BaseRepository<TEntity,TKey>:IRepository<TEntity,TKey>
        where TEntity:class,IEntity<TKey>
    {

        public System.Linq.IQueryable<TEntity> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public System.Collections.Generic.IList<TEntity> GetAllList()
        {
            throw new System.NotImplementedException();
        }

        public System.Threading.Tasks.Task<System.Collections.Generic.IList<TEntity>> GetAllListAsync()
        {
            throw new System.NotImplementedException();
        }

        public System.Collections.Generic.IList<TEntity> GetAllList(System.Linq.Expressions.Expression<System.Func<TEntity, bool>> predicate)
        {
            throw new System.NotImplementedException();
        }

        public System.Collections.Generic.IList<TEntity> GetAllListAsync(System.Linq.Expressions.Expression<System.Func<TEntity, bool>> predicate)
        {
            throw new System.NotImplementedException();
        }

        public T Queary<T>(System.Func<System.Linq.IQueryable<TEntity>, T> queryMethod)
        {
            throw new System.NotImplementedException();
        }

        public TEntity Get(TKey id)
        {
            throw new System.NotImplementedException();
        }

        public System.Threading.Tasks.Task<TEntity> GetAsync(TKey id)
        {
            throw new System.NotImplementedException();
        }

        public TEntity Single(System.Linq.Expressions.Expression<System.Func<TEntity, bool>> predicate)
        {
            throw new System.NotImplementedException();
        }

        public System.Threading.Tasks.Task<TEntity> SingleAsync(System.Linq.Expressions.Expression<System.Func<TEntity, bool>> predicate)
        {
            throw new System.NotImplementedException();
        }

        public TEntity FirstOrDefault(TKey id)
        {
            throw new System.NotImplementedException();
        }

        public System.Threading.Tasks.Task<TEntity> FirstOrDefaultAsync(TKey id)
        {
            throw new System.NotImplementedException();
        }

        public TEntity FirstOrDefault(System.Linq.Expressions.Expression<System.Func<TEntity, bool>> predicate)
        {
            throw new System.NotImplementedException();
        }

        public System.Threading.Tasks.Task<TEntity> FirstOrDefaultAsync(System.Linq.Expressions.Expression<System.Func<TEntity, bool>> predicate)
        {
            throw new System.NotImplementedException();
        }

        public TEntity Load(TKey id)
        {
            throw new System.NotImplementedException();
        }

        public TEntity Insert(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public System.Threading.Tasks.Task<TEntity> InsertAsync(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public TKey InsertAndGetId(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public System.Threading.Tasks.Task<TKey> InsertAndGetIdAsync(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public TEntity InsertOrUpdate(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public System.Threading.Tasks.Task<TEntity> InsertOrUpdateAsync(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public TKey InsertOrUpdateAndGetId(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public System.Threading.Tasks.Task<TKey> InsertOrUpdateAndGetIdAsync(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public TEntity Update(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public System.Threading.Tasks.Task<TEntity> UpdateAsync(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(TKey id)
        {
            throw new System.NotImplementedException();
        }

        public System.Threading.Tasks.Task DeleteAsync(TKey id)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(System.Linq.Expressions.Expression<System.Func<TEntity, bool>> predicate)
        {
            throw new System.NotImplementedException();
        }

        public System.Threading.Tasks.Task DeleteAsync(System.Linq.Expressions.Expression<System.Func<TEntity, bool>> predicate)
        {
            throw new System.NotImplementedException();
        }

        public int Count()
        {
            throw new System.NotImplementedException();
        }

        public System.Threading.Tasks.Task<int> CountAsync()
        {
            throw new System.NotImplementedException();
        }

        public int Count(System.Linq.Expressions.Expression<System.Func<TEntity, bool>> predicate)
        {
            throw new System.NotImplementedException();
        }

        public System.Threading.Tasks.Task<int> CountAsync(System.Linq.Expressions.Expression<System.Func<TEntity, bool>> predicate)
        {
            throw new System.NotImplementedException();
        }

        public long LongCount()
        {
            throw new System.NotImplementedException();
        }

        public System.Threading.Tasks.Task<long> LongCountAsync()
        {
            throw new System.NotImplementedException();
        }

        public long LongCount(System.Linq.Expressions.Expression<System.Func<TEntity, bool>> predicate)
        {
            throw new System.NotImplementedException();
        }

        public long LongCountAsync(System.Linq.Expressions.Expression<System.Func<TEntity, bool>> predicate)
        {
            throw new System.NotImplementedException();
        }
    }
}