using System;
using System.Collections.Generic;
using System.Text;
using StockMarket.Model.Quantitative;

namespace StockMarket.DAL.Interface.Persistance.Repositories {
    public interface IStockSummaryDAL {
        StockSummary getStockSumarryByIndex (string StockIndex);
        IEnumerable<StockSummary> getAllStockSumaries ();

    }
}