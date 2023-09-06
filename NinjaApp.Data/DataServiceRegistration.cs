using Microsoft.Extensions.DependencyInjection;
using NinjaApp.Data.Interfaces;
using NinjaApp.Data.Repositories;

namespace NinjaApp.Data
{
    public class DataServiceRegistration
    {
        ServiceProvider serviceProvider;


        /// <summary>
        /// projeye dahil ettigimiz repositoryleri buraya eklenecek!
        /// </summary>
        public DataServiceRegistration()
        {
            serviceProvider = new ServiceCollection().AddScoped<IProductRepository, ProductRepository>().AddScoped<IReceiptRepository, ReceiptRepository>().BuildServiceProvider();


        }


        /// <summary>
        /// Bana product repository içeriğini getirir.
        /// </summary>        
        public IProductRepository GetProductRepositoryInstance()
        {
            return serviceProvider.GetRequiredService<IProductRepository>();
        }


        /// <summary>
        /// Bana Receipt repository içeriğini getirir.
        /// </summary> 
        public IReceiptRepository GetReceiptRepositoryInstance()
        {
            return serviceProvider.GetRequiredService<IReceiptRepository>();
        }



    }
}
