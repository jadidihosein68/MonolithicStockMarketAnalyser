using StockMarket.DAL.DBContext;
using StockMarket.DAL.Interface.Persistance.Repositories;
using StockMarket.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace StockMarket.DAL.Persistence.Repositories
{
    public class TwitterDAL : ITwitterDAL
    {

        private readonly ISalDbContext context;
        public TwitterDAL(ISalDbContext _context)
        {
            context = _context;
        }

        public IEnumerable<Tweet> get()
        {
            return null;
        }

    }
}
