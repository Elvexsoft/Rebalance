using Newtonsoft.Json;
using Rebalance.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace Rebalance.Services
{
    public class StockService : IStockService
    {
        private readonly IStockRepository stockRepository;

        public StockService(IStockRepository stockRepository)
        {
            this.stockRepository = stockRepository;
        }

        public string GetStockPrices()
        {
            var stocks = string.Empty;

            var symbols = GetSymbols();

            using (var client = new HttpClient())
            {
                var responseTask = client.GetAsync($"https://financialmodelingprep.com/api/v3/quote/AAPL,{symbols}");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    var readTask = result.Content.ReadAsStringAsync();
                    readTask.Wait();

                    stocks = readTask.Result;

                }
            }

            return stocks;
        }

        public IEnumerable<Stock> GetPortfolio()
        {
            var stocks = stockRepository.GetPortfolio();

            var stockPrices = GetStockPrices();
            var currentPrices = JsonConvert.DeserializeObject<List<Stock>>(stockPrices);
            double portfolioTotal = 0;

            foreach(var price in currentPrices)
            {
                var position = stocks.Where(s => s.Symbol == price.Symbol).Select(s => s.Position).FirstOrDefault();
                portfolioTotal += price.Price * position;
            }

            foreach (var stock in stocks)
            {
                double price = currentPrices.Where(s => s.Symbol == stock.Symbol).Select(s => s.Price).FirstOrDefault();

                double total = price * stock.Position;

                if (stock.Percent > 0)
                {
                    double allocation = portfolioTotal * (stock.Percent / 100f);

                    stock.NewPosition = Convert.ToInt32(allocation / price);
                    stock.Buy = stock.NewPosition > stock.Position ? stock.NewPosition - stock.Position : 0;
                    stock.Sell = stock.Position > stock.NewPosition ? stock.Position = stock.NewPosition : 0;
                }
                else
                {
                    stock.Sell = stock.Position;
                }
            }

            return stocks;
        }

        private string GetSymbols()
        {
            var stocks = stockRepository.GetPortfolio().Select(s => s.Symbol).ToList();

            return string.Join(",", stocks);
        }
    }
}
