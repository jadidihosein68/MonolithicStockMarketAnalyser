using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockMarket.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.DAL.Persistence.EntityConfigurations
{

    public class StockFocuseConfigration : IEntityTypeConfiguration<StockFocuse>
    {
        public void Configure(EntityTypeBuilder<StockFocuse> builder)
        {
            /*
            builder.HasKey(c => c.Id);
            builder.HasMany(e => e.StockLabels)
                .WithOne(x=>x.StockFocuse);
            */    
        }
    }
}
