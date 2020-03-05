using System;
using System.ComponentModel;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Rebalance.Repository;
using Rebalance.Services;

namespace Rebalance
{
    static class Program
    {
        private static Container container;
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Bootstrap();
        }

        private static void Bootstrap()
        {
            var services = new ServiceCollection();

            ConfigureServices(services);

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var stockService = services.BuildServiceProvider().GetRequiredService<IStockService>();
                var stockRepository = services.BuildServiceProvider().GetRequiredService<IStockRepository>();

                Application.Run(new Rebalance(stockService));
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddSingleton<IStockRepository, StockRepository>()
                .AddSingleton<IStockService, StockService>();
        }
    }
}
