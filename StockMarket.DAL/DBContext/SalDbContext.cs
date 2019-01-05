using Microsoft.EntityFrameworkCore;
using StockMarket.DAL.Persistence.EntityConfigurations;
using StockMarket.Model;
using StockMarket.Model.Base;
using StockMarket.Model.Quantitative;
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
        public DbSet<StockFocuse> StockFocuse { get; set; }
        public DbSet<RowHistoricalStockBase> TimeSeries { get; set; }
        public DbSet<TimeSeries> TimeSeriesReal { get; set; }
        public DbSet<MACDIndex> MACDIndex { get; set; }
        public DbSet<RSIIndex> RSIIndex { get; set; }
        public DbSet<GuppyIndex> GuppyIndex { get; set; }
        public DbSet<SOIndex> SOIndex { get; set; }






        // Views 
        public DbQuery<TweetsSummary> TweetsSummary { get; set; }
        public DbQuery<StockSummary> StockSummary { get; set; }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Query<TweetsSummary>().ToView("View_TweetsSummary");
            modelBuilder.Query<StockSummary>().ToView("View_StockSummary");

            modelBuilder.ApplyConfiguration(new TweetConfigration());
            modelBuilder.ApplyConfiguration(new StockFocuseConfigration());
           // modelBuilder.ApplyConfiguration(new StockLabelConfigration());
            modelBuilder.ApplyConfiguration(new TimeSeriesConfigration());
            modelBuilder.ApplyConfiguration(new TimeSeriesRealConfigration());
            //  modelBuilder.ApplyConfiguration(new TimeSeriesMACDConfigration());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

    }
}
