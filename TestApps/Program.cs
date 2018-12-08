using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarket.Adapter;
using StockMarket.BAL.Generate_TimeSeries;
using StockMarket.DAL.Interface.Persistance.Repositories;
using StockMarket.DAL.Persistence.Repositories;
using StockMarket.Model;


namespace TestApps
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var RHub = new RHub();
            var abu = RHub.execute();

            Console.Read();
        }
    }
}
