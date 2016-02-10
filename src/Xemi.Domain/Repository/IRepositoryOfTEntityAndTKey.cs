using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Xemi.Domain.Entities;

namespace Xemi.Domain.Repository
{
    public interface IRepository<TEntity, TKey> : IRepository where TEntity : IEntity<TKey>
    {
        IQueryable<TEntity> GetAll();

        IList<TEntity> GetAllList();

        Task<IList<TEntity>> GetAllListAsync();

        IList<TEntity> GetAllList(Expression<Func<TEntity, bool>> predicate);

        Task<IList<TEntity>> GetAllListAsync(Expression<Func<TEntity, bool>> predicate);

        T Queary<T>(Func<IQueryable<TEntity>, T> queryMethod);

        TEntity Get(TKey id);

        Task<TEntity> GetAsync(TKey id);

        TEntity Single(Expression<Func<TEntity, bool>> predicate);

        Task<TEntity> SingleAsync(Expression<Func<TEntity, bool>> predicate);

        TEntity FirstOrDefault(TKey id);

        Task<TEntity> FirstOrDefaultAsync(TKey id);

        TEntity FirstOrDefault(Expression<Func<TEntity, bool>> predicate);

        Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);

        TEntity Load(TKey id);

        TEntity Insert(TEntity entity);

        Task<TEntity> InsertAsync(TEntity entity);

        TKey InsertAndGetId(TEntity entity);

        Task<TKey> InsertAndGetIdAsync(TEntity entity);

        TEntity InsertOrUpdate(TEntity entity);

        Task<TEntity> InsertOrUpdateAsync(TEntity entity);

        TKey InsertOrUpdateAndGetId(TEntity entity);

        Task<TKey> InsertOrUpdateAndGetIdAsync(TEntity entity);

        TEntity Update(TEntity entity);

        Task<TEntity> UpdateAsync(TEntity entity);

        void Delete(TKey id);

        Task DeleteAsync(TKey id);

        void Delete(TEntity entity);

        Task DeleteAsync(TEntity entity);

        void Delete(Expression<Func<TEntity, bool>> predicate);

        Task DeleteAsync(Expression<Func<TEntity, bool>> predicate);

        int Count();

        Task<int> CountAsync();

        int Count(Expression<Func<TEntity, bool>> predicate);

        Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate);

        long LongCount();

        Task<long> LongCountAsync();

        long LongCount(Expression<Func<TEntity, bool>> predicate);

        Task<long> LongCountAsync(Expression<Func<TEntity, bool>> predicate);
    }
}