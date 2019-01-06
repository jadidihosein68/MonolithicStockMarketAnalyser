using System;
using System.Collections.Generic;
using System.Text;
using StockMarket.Model.Quantitative;

namespace StockMarket.DAL.Interface.Persistance.Repositories {
    public interface IMACDDAL {
        void AddRange (IEnumerable<MACDIndex> DataSet);

    }
}