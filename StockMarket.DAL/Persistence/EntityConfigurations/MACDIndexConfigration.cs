using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockMarket.Model.Quantitative;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.DAL.Persistence.EntityConfigurations
{
    public class MACDIndexConfigration : IEntityTypeConfiguration<MACDIndex>
    {
        public void Configure(EntityTypeBuilder<MACDIndex> builder)
        {
            
                 builder.HasKey(c => c.MACDId);
            /*
                builder.HasOne(d => d.TimeSeries)
                    .WithOne(c=>c.MACDIndex)
                    .HasForeignKey<MACDIndex>(d => d.TimeSeriesId);
              */      

        }

    }
}
