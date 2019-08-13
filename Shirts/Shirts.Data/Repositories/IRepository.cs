using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shirts.Data.Repositories
{
    public interface IRepository<T>
    {
        IQueryable<T> All();

        T Find(T entity);

        T Add(T entity);


        T Find(object id);

        T Update(T entity);

        void Delete(T entity);

        int SaveChanges();
    }
}
