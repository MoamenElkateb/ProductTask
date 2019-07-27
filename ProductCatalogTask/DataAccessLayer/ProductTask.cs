using Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccessLayer
{
    public class ProductTask:DbContext
    {
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=ProductTask;Trusted_Connection=True;");
        }
    }
}
