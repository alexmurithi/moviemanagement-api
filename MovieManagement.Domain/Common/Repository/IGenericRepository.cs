using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagement.Domain.Common.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        T? GetById(Guid id);

        Task<T?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);

        T? Get(Expression<Func<T,bool>> predicate);

        IEnumerable<T> GetAll();

        Task<IEnumerable<T>> GetAllAsync(CancellationToken cancellationToken = default);

        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);

        void Add(T entity);

        void AddRange(IEnumerable<T> entities);

        void Update(T entity);

        void Remove(T entity);

        void RemoveRange(IEnumerable<T> entities);
    }
}
