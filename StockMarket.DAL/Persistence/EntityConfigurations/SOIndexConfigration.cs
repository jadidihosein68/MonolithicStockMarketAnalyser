using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockMarket.Model.Quantitative;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.DAL.Persistence.EntityConfigurations
{
    public class SOIndexConfigration : IEntityTypeConfiguration<SOIndex>
    {
        public void Configure(EntityTypeBuilder<SOIndex> builder)
        {

        }

    }
}
