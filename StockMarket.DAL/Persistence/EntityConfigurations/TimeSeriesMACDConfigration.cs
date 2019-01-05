using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockMarket.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.DAL.Persistence.EntityConfigurations
{


    public class TimeSeriesMACDConfigration : IEntityTypeConfiguration<MACDHistoricalStock>
    {
        public void Configure(EntityTypeBuilder<MACDHistoricalStock> builder)
        {
            builder.Property(f => f.Id).ValueGeneratedOnAdd();
        }
    }
}
