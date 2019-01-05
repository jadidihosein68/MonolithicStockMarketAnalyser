using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using StockMarket.Model;
using StockMarket.Model.Base;
using StockMarket.Model.Quantitative;

namespace StockMarket.DAL.DBContext {
    public interface ISalDbContext {
        DbQuery<TweetsSummary> TweetsSummary { get; set; }
        DbQuery<StockSummary> StockSummary { get; set; }

        DbSet<Tweet> Tweet { get; set; }
        DbSet<RowHistoricalStockBase> TimeSeries { get; set; }

        DbSet<StockFocuse> StockFocuse { get; set; }
        DbSet<TimeSeriesIndex> TimeSeriesIndex { get; set; }
        DbSet<MACDIndex> MACDIndex { get; set; }
        DbSet<RSIIndex> RSIIndex { get; set; }
        DbSet<GuppyIndex> GuppyIndex { get; set; }
        DbSet<SOIndex> SOIndex { get; set; }

    }
}