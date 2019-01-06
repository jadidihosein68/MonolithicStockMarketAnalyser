using System;
using System.Collections.Generic;
using System.Text;
using StockMarket.DAL.DBContext;
using StockMarket.DAL.Interface.Persistance.Repositories;
using StockMarket.Model.Quantitative;

namespace StockMarket.DAL.Persistence.Repositories {
    public class RSIDAL : IRSIDAL {
        private readonly ISalDbContext context;
        public RSIDAL (ISalDbContext _context) {
            context = _context;
        }
        public void AddRange (IEnumerable<RSIIndex> DataSet) {
            context.RSIIndex.AddRange (DataSet);
        }
    }
}