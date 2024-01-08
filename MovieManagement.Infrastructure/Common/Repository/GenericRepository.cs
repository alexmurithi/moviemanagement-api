using Microsoft.EntityFrameworkCore;
using MovieManagement.Domain.Common.Repository;
using MovieManagement.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagement.Infrastructure.Common.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly MovieManagementDbContext _dbContext;

        private readonly DbSet<T> _dbSet;

        public GenericRepository(MovieManagementDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }

        public void Add(T entity)
        {
           _dbContext.Add<T>(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.AsEnumerable();
        }

        public async Task<IEnumerable<T>> GetAllAsync(CancellationToken cancellationToken = default)
            => await _dbSet.ToListAsync(cancellationToken);

        public T? GetById(Guid id)
        {
            return _dbSet.Find(id);
        }

        public async Task<T?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
            => await _dbSet.FindAsync(id, cancellationToken);

        public void Update(T entity)
        {
            _dbContext.Update<T>(entity);
        }

        public T? Get(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.FirstOrDefault(predicate);
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
           return _dbSet.Where(predicate).AsEnumerable();
        }

        public void AddRange(IEnumerable<T> entities)
        {
             _dbContext.AddRange(entities);
        }

        public void Remove(T entity)
        {
            _dbContext.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            _dbContext.RemoveRange(entities);
        }
    }
}
