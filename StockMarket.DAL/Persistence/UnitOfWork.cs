using StockMarket.DAL.DBContext;
using StockMarket.DAL.Interface.Persistance;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket.DAL.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SalDbContext context;

        public UnitOfWork(SalDbContext _context)
        {
            context = _context;
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
