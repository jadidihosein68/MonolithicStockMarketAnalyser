using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using StockMarket.DAL.Interface.Persistance.Repositories;

namespace StockMarket.DAL.Interface.Persistance {
    public interface IUnitOfWork {
        ITwitterDAL TwitterDAL { get; }
        ITimeSeriesDAL TimeSeriesDAL { get; }
        void Complite ();
        Task CompliteAsync ();

    }
}