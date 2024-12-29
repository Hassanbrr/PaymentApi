using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstraction
{
    public interface IRepository<T> where T : class
    {

        IQueryable<T> GetAll();
        IQueryable<T> GetById(Expression<Func<T, bool>> filter);
        Task Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task Save();



    }
}
