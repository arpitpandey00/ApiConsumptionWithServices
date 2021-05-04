using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace UpdatedcCudApi
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-7SR91DD\SQLEXPRESS;Initial Catalog=ProductMay;User ID=sa;Password=pandey10");
            //base.OnConfiguring(optionsBuilder);
        }
    }
}
