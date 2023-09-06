﻿using Microsoft.Extensions.DependencyInjection;
using NinjaApp.Business.Managers;
using NinjaApp.Business.Services;

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
            serviceProvider = new ServiceCollection().AddScoped<IProductService, ProductManager>().AddScoped<IStockService, StockManager>().AddScoped<IPriceEditService, PriceEditManager>().AddScoped<IChartService, ChartManager>().BuildServiceProvider();


        }


        /// <summary>
        /// Bu metot Product service içeriğini getirir.
        /// </summary>
        public IProductService GetProductServiceInstance()
        {
            return serviceProvider.GetRequiredService<IProductService>();
        }

        /// <summary>
        /// Bu metot Stok service içeriğini getirir.
        /// </summary>
        public IStockService GetStockServiceInstance()
        {
            return serviceProvider.GetRequiredService<IStockService>();
        }

        /// <summary>
        /// Bu metot PriceEdit service içeriğini getirir.
        /// </summary>
        public IPriceEditService GetPriceEditServiceInstance()
        {
            return serviceProvider.GetRequiredService<IPriceEditService>();
        }

        /// <summary>
        /// Bu metot chart service içeriğini getirir.
        /// </summary>        
        public IChartService GetChartServiceInstance()
        {
            return serviceProvider.GetRequiredService<IChartService>();
        }
    }
}
