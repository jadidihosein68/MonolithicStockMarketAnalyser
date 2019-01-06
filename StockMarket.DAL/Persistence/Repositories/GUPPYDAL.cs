using System;
using System.Collections.Generic;
using System.Text;
using StockMarket.DAL.DBContext;
using StockMarket.DAL.Interface.Persistance.Repositories;
using StockMarket.Model.Quantitative;

namespace StockMarket.DAL.Persistence.Repositories {
    public class GUPPYDAL : IGUPPYDAL {
        private readonly ISalDbContext context;
        public GUPPYDAL (ISalDbContext _context) {
            context = _context;
        }
        public void AddRange (IEnumerable<GuppyIndex> DataSet) {
            context.GuppyIndex.AddRange (DataSet);
        }

    }
}