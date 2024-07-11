using System;
using System.Data.Entity;

namespace ProductManager.Models
{
    public class DbContext : System.Data.Entity.DbContext
    {
        public DbContext() : base("name=ProductManager") 
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
