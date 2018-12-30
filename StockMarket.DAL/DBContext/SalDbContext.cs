using Microsoft.EntityFrameworkCore;
using StockMarket.DAL.Persistence.EntityConfigurations;
using StockMarket.Model;
using System.Collections.Generic;

namespace StockMarket.DAL.DBContext
{
    public class SalDbContext : DbContext , ISalDbContext
    {
        public SalDbContext(DbContextOptions<SalDbContext> options)
            : base(options)
        { }
        
        // Models
        public DbSet<Tweet> Tweet { get; set; }

        // Views 
        public DbQuery<TweetsSummary> TweetsSummary { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Query<TweetsSummary>().ToView("View_TweetsSummary");

            modelBuilder.ApplyConfiguration(new TweetConfigration());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

    }
}
