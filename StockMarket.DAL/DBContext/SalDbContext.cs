using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace StockMarket.DAL.DBContext
{
    public class SalDbContext : DbContext
    {
        public SalDbContext(DbContextOptions<SalDbContext> options)
            : base(options)
        { }

        // public DbSet<Blog> Blogs { get; set; }
    }
}
