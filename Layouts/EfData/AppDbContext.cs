using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfData
{
    public class AppDbContext : DbContext
    {
        public AppDbContext():base("DefaultConnection")
        {
            Database.SetInitializer<AppDbContext>(new CreateDatabaseIfNotExists<AppDbContext>());

        }

        public IDbSet<Shoe> Shoes{ get; set; }
    }
}
