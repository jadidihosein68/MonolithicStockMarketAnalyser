using StockMarket.DAL.Interface.Persistance.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.DAL.Interface.Persistance
{
    public interface IUnitOfWork
    {
        ITwitterDAL TwitterDAL { get;}
    }
}
