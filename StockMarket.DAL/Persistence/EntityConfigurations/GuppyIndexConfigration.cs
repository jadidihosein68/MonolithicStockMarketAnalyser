using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockMarket.Model.Quantitative;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.DAL.Persistence.EntityConfigurations
{
    public class GuppyIndexConfigration : IEntityTypeConfiguration<GuppyIndex>
    {
        public void Configure(EntityTypeBuilder<GuppyIndex> builder)
        {
            builder.HasKey(c => c.GuppyId);
            /*
            builder.HasOne(d => d.TimeSeries)
                .WithOne(c => c.GuppyIndex)
                .HasForeignKey<GuppyIndex>(d => d.TimeSeriesId);
                */
        }

    }
}
