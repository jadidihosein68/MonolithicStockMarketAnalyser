using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StockMarket.DAL.DBContext;
using StockMarket.DAL.Interface.Persistance.Repositories;
using StockMarket.Model.Quantitative;

namespace StockMarket.DAL.Persistence.Repositories {
    public class StockSummaryDAL : IStockSummaryDAL {
        private readonly ISalDbContext context;
        public StockSummaryDAL (ISalDbContext _context) {
            context = _context;
        }
        public StockSummary getStockSumarryByIndex (string StockIndex) {
            return context.StockSummary.FirstOrDefault (x => x.StockIndex == StockIndex);
        }

        public IEnumerable<StockSummary> getAllStockSumaries () {
            return context.StockSummary.ToList ();
        }

    }
}