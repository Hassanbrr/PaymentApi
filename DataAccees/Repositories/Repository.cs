using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Application.Abstraction;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccees.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly PaymentDetailContext _db;
        internal DbSet<T> dbSet;
        public Repository(PaymentDetailContext db)
        {
            _db = db;
            this.dbSet = _db.Set<T>();
        }

        public async Task Create(T entity)
        {
            await dbSet.AddAsync(entity);
        }
        public void Delete(T entity)
        {
            dbSet.Remove(entity);
        }
        public IQueryable<T> GetAll()
        {
            throw new NotImplementedException();
        }
        public IQueryable<T> GetById(Expression<Func<T, bool>> filter)
        {
            IQueryable<T> query = dbSet.Where(filter);
            return query;

        }
        public async Task Save()
        {
            await _db.SaveChangesAsync();   
        }

        public void Update(T entity)
        {
           dbSet.Update(entity);    
        }
    }
}
