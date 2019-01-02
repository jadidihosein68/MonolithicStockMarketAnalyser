using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockMarket.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.DAL.Persistence.EntityConfigurations
{
    public class StockLabelConfigration : IEntityTypeConfiguration<StockLabel>
    {
        public void Configure(EntityTypeBuilder<StockLabel> builder)
        {
            builder.HasKey(c => c.StockLabelId);
            builder.Property(a => a.StockFocuseID).IsRequired();
        }
    }
}
