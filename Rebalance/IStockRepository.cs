using System.Collections.Generic;

namespace Rebalance.Repository
{
    public interface IStockRepository
    {
        IEnumerable<Stock> GetPortfolio();
    }
}