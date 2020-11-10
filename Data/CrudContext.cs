using CRUD.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Data
{
    public class CrudContext : DbContext
    {
        public CrudContext(DbContextOptions<CrudContext> options) : base (options)
        {

        }

        public DbSet<Employee> employees { get; set; }
        public DbSet<Product> products { get; set; }
    }
}
