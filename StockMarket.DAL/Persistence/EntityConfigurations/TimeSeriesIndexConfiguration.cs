using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockMarket.Model;
using StockMarket.Model.Base;
using StockMarket.Model.Quantitative;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.DAL.Persistence.EntityConfigurations
{
    public class TimeSeriesIndexConfiguration : IEntityTypeConfiguration<TimeSeriesIndex>
    {
        public void Configure(EntityTypeBuilder<TimeSeriesIndex> builder)
        {
            
            
           // builder.HasKey(c=>c.Id);
            //builder.Property(f => f.Id).ValueGeneratedOnAdd();
            // builder.HasKey(c => c.Id);
            /*
                        modelBuilder.Entity<Foo>()
                        .Property(f => f.Id)
                        .ValueGeneratedOnAdd();
                        */
            /*
builder.HasOne(a => a.MACDIndex)
    .WithOne(b => b.TimeSeries)
    .HasForeignKey<MACDIndex>(b => b.TimeSeriesId);
    */
            /*
            builder.HasOne(a => a.RSIIndex)
                .WithOne(b => b.TimeSeries)
                .HasForeignKey<RSIIndex>(b => b.TimeSeriesId);

            builder.HasOne(a => a.SOIndex)
                .WithOne(b => b.TimeSeries)
                .HasForeignKey<SOIndex>(b => b.TimeSeriesId);

            builder.HasOne(a => a.GuppyIndex)
                .WithOne(b => b.TimeSeries)
                .HasForeignKey<GuppyIndex>(b => b.TimeSeriesId);
                */
        }
    }
}
