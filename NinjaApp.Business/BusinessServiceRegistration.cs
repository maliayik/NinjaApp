using Microsoft.Extensions.DependencyInjection;
using NinjaApp.Business.Interfaces;
using NinjaApp.Business.Managers;
using NinjaApp.Business.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjaApp.Business
{
    public class BusinessServiceRegistration
    {
        ServiceProvider serviceProvider;


        /// <summary>
        /// Projeye dahil ettigimiz Servicelerimizi buraya eklicez.
        /// </summary>
        public BusinessServiceRegistration()
        {
            serviceProvider = new ServiceCollection().AddScoped<ITestService,TestManager>().AddScoped<IProductService,ProductManager>().AddScoped<IStockService,StockManager>().BuildServiceProvider();

            
        }

        public ITestService GetTestServiceInstance()
        {
            return serviceProvider.GetRequiredService<ITestService>();
        }

        public IProductService GetProductServiceInstance()
        {
            return serviceProvider.GetRequiredService<IProductService>();
        }

        public IStockService GetStockServiceInstance()
        {
            return serviceProvider.GetRequiredService<IStockService>();
        }

    }
}
