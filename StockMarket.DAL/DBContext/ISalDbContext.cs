using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using StockMarket.Model;
using StockMarket.Model.Base;

namespace StockMarket.DAL.DBContext
{
    public interface ISalDbContext
    {
        DbSet<Tweet> Tweet { get; set; }
        DbSet<RowHistoricalStockBase> TimeSeries { get; set; }
        DbQuery<TweetsSummary> TweetsSummary { get; set; }

    }
}