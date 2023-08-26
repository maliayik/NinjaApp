using Microsoft.Extensions.DependencyInjection;
using NinjaApp.Data.Interfaces;
using NinjaApp.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            serviceProvider = new ServiceCollection().AddScoped<ITestRepository,TestRepository>().BuildServiceProvider();  
            
            
        }

        public ITestRepository  GetTestRepositoryInstance()
        {
            return serviceProvider.GetRequiredService<ITestRepository>();
        }
    }
}
