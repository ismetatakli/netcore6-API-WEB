﻿using System.Linq.Expressions;

namespace Core6App.Core.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        IQueryable<T> Where(Expression<Func<T,bool>> expression);
        Task AddAsync(T entity);
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
        void Update(T entity);
        void Remove(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        void RemoveRange(IEnumerable<T> entities);
        IQueryable<T> GetAll(Expression<Func<T, bool>> expression);
    }

}
