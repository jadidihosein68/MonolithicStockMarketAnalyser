using System;
using System.Collections.Generic;
using System.Text;
using StockMarket.DAL.DBContext;
using StockMarket.DAL.Interface.Persistance.Repositories;
using StockMarket.Model.Quantitative;

namespace StockMarket.DAL.Persistence.Repositories {
    public class MACDDAL : IMACDDAL {
        private readonly ISalDbContext context;
        public MACDDAL (ISalDbContext _context) {
            context = _context;
        }
        public void AddRange (IEnumerable<MACDIndex> DataSet) {
            context.MACDIndex.AddRange (DataSet);
        }

    }
}