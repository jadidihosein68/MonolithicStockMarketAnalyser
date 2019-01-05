using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockMarket.Model.Quantitative;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.DAL.Persistence.EntityConfigurations
{
    public class RSIIndexConfigration : IEntityTypeConfiguration<RSIIndex>
    {
        public void Configure(EntityTypeBuilder<RSIIndex> builder)
        {

        }

    }
}
