using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockMarket.Model.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.DAL.Persistence.EntityConfigurations
{
    public class TimeSeriesConfigration : IEntityTypeConfiguration<RowHistoricalStockBase>
    {
        public void Configure(EntityTypeBuilder<RowHistoricalStockBase> builder)
        {
            builder.Property(f => f.Id).ValueGeneratedOnAdd();
            

            // throw new NotImplementedException();
        }
    }
}
