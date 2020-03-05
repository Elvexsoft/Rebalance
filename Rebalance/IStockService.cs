using System.Collections.Generic;

namespace Rebalance.Services
{
    public interface IStockService
    {
        string GetStockPrices();
        IEnumerable<Stock> GetPortfolio();
    }
}