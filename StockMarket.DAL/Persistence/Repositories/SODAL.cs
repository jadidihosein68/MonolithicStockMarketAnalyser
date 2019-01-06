using System;
using System.Collections.Generic;
using System.Text;
using StockMarket.DAL.DBContext;
using StockMarket.DAL.Interface.Persistance.Repositories;
using StockMarket.Model.Quantitative;

namespace StockMarket.DAL.Persistence.Repositories {
    public class SODAL : ISODAL {
        private readonly ISalDbContext context;
        public SODAL (ISalDbContext _context) {
            context = _context;
        }
        public void AddRange (IEnumerable<SOIndex> DataSet) {
            context.SOIndex.AddRange (DataSet);
        }
    }
}