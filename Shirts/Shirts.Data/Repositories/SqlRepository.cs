using Shirts.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shirts.Data.Repositories
{
    public class SqlRepository<T> : IRepository<T> where T : class
    {
        private ApplicationDbContext context;
        private DbSet<T> set;

        public SqlRepository(ApplicationDbContext context)
        {
            this.context = context;
            set = context.Set<T>();
        }

        public T Add(T entity)
        {
            var newEntity = set.Add(entity);
            return newEntity;
        }

        public IQueryable<T> All()
        {
            return set.AsQueryable();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public T Find(T entity)
        {
            return set.Find(entity);
        }

        public T Find(object id)
        {
            return set.Find(id);
        }

        public int SaveChanges()
        {
            return context.SaveChanges();
        }

        public T Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
