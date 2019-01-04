using StockMarket.DAL.DBContext;
using StockMarket.DAL.Interface.Persistance;
using StockMarket.DAL.Interface.Persistance.Repositories;
using StockMarket.DAL.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket.DAL.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SalDbContext context;

        public ITwitterDAL TwitterDAL { get; private set; }
        public ITimeSeriesDAL TimeSeriesDAL { get; private set; }

        public UnitOfWork(SalDbContext _context)
        {
            context = _context;
            TwitterDAL = new TwitterDAL(_context);
            TimeSeriesDAL = new TimeSeriesDAL(_context);

        }
        
        public void Complite()
        {
            context.SaveChanges();
        }

        public async Task CompliteAsync()
        {
            await context.SaveChangesAsync();

        }

        

    }
}
