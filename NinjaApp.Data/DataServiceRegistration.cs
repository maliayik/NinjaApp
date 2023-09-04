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
            serviceProvider = new ServiceCollection().AddScoped<ITestRepository,TestRepository>().AddScoped<IProductRepository,ProductRepository>().BuildServiceProvider();  
            
          
        }

        public ITestRepository  GetTestRepositoryInstance()
        {
            return serviceProvider.GetRequiredService<ITestRepository>();
        }

        public IProductRepository GetProductRepositoryInstance()
        {
            return serviceProvider.GetRequiredService<IProductRepository>();
        }
    }
}
