using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebalance.Repository
{
    public class StockRepository : IStockRepository
    { 
        public StockRepository()
        {

        }

        public IEnumerable<Stock> GetPortfolio()
        {
            return new List<Stock>
            {
                new Stock
                {
                    Symbol = "AAPL",
                    Position = 50,
                    Percent = 22
                },
                new Stock
                {
                    Symbol = "GOOG",
                    Position = 200,
                    Percent = 38
                },
                new Stock
                {
                    Symbol = "CYBR",
                    Position = 150,
                    Percent = 0
                },
                new Stock
                {
                    Symbol = "ABB",
                    Position = 900,
                    Percent = 0
                },
                new Stock
                {
                    Symbol = "GFN",
                    Percent = 25
                },
                new Stock
                {
                    Symbol = "ACAD",
                    Percent = 15
                }
            };
        }
    }
}
