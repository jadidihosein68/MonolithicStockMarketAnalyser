using Microsoft.EntityFrameworkCore;
using StockMarket.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.DAL.DBContext
{
    public interface ISalDbContext
    {
         DbSet<Tweet> Tweet { get; set; }
    }
}
