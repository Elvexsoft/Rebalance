using Rebalance.Services;
using System;
using System.Windows.Forms;

namespace Rebalance
{
    public partial class Rebalance : Form
    {
        private readonly IStockService stockService;
        public Rebalance(IStockService stockService)
        {
            this.stockService = stockService;
            InitializeComponent();

            var stocks = stockService.GetPortfolio();

            foreach(var stock in stocks)
            {
                this.CurrentPortfolioGrid.Rows.Add(stock.Symbol, stock.Position);
                this.DesiredPortfolioGrid.Rows.Add(stock.Symbol, $"{stock.Percent}%");
                this.RebalanceGrid.Rows.Add(stock.Symbol, stock.Buy.ToString(), stock.Sell.ToString(), $"{stock.Percent}%");
            }


            //this.RebalanceGrid.Rows.Add("AAPL", Convert.ToInt32(aaplNumber - 50).ToString(), "0", "22%");
            //this.RebalanceGrid.Rows.Add("GOOG", "0", Convert.ToInt32(200-googNumber).ToString(), "38%");
            //this.RebalanceGrid.Rows.Add("CYBR", "0", "150", "0%");
            //this.RebalanceGrid.Rows.Add("ABB", "0", "900", "0%");
            //this.RebalanceGrid.Rows.Add("GFN", gfnNumber.ToString(), "0", "25%");
            //this.RebalanceGrid.Rows.Add("ACAD", acadNumber.ToString(), "0", "15%");
        }

    }
}
