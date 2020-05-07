using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Proj2_CRUD.Models
{
    public class Context : DbContext
    {
        public DbSet<Car> Cars { get; set; }

        public Context(DbContextOptions<Context> options) : base (options)
        {
        }
    }
}
