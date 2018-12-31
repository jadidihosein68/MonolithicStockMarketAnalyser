using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockMarket.Model;

namespace StockMarket.DAL.Persistence.EntityConfigurations {
    public class TweetConfigration : IEntityTypeConfiguration<Tweet> {
        public void Configure (EntityTypeBuilder<Tweet> builder) {
            builder.Property (b => b.CreateDate)
                .HasDefaultValueSql ("getdate()");
        }
    }
}