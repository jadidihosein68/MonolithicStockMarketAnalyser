using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using StockMarket.Model;

namespace StockMarket.DAL.DBContext {
    public interface ISalDbContext {
        DbSet<Tweet> Tweet { get; set; }
        DbQuery<TweetsSummary> TweetsSummary { get; set; }

    }
}