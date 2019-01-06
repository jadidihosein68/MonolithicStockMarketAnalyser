using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using StockMarket.DAL.DBContext;
using StockMarket.DAL.Interface.Persistance;
using StockMarket.DAL.Interface.Persistance.Repositories;
using StockMarket.DAL.Persistence.Repositories;

namespace StockMarket.DAL.Persistence {
    public class UnitOfWork : IUnitOfWork {
        private readonly SalDbContext context;

        public ITwitterDAL TwitterDAL { get; private set; }
        public ITimeSeriesDAL TimeSeriesDAL { get; private set; }
        public IGUPPYDAL GUPPYDAL { get; private set; }
        public IMACDDAL MACDDAL { get; private set; }
        public ISODAL SODAL { get; private set; }
        public IRSIDAL RSIDAL { get; private set; }
        public IStockSummaryDAL StockSummaryDAL { get; private set; }

        public UnitOfWork (SalDbContext _context) {
            context = _context;
            TwitterDAL = new TwitterDAL (_context);
            TimeSeriesDAL = new TimeSeriesDAL (_context);
            GUPPYDAL = new GUPPYDAL (_context);
            MACDDAL = new MACDDAL (_context);
            SODAL = new SODAL (_context);
            RSIDAL = new RSIDAL (_context);
            StockSummaryDAL = new StockSummaryDAL (_context);

        }

        public void Complite () {
            context.SaveChanges ();
        }

        public async Task CompliteAsync () {
            await context.SaveChangesAsync ();

        }

    }
}