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
            serviceProvider = new ServiceCollection().AddScoped<IProductRepository, ProductRepository>().AddScoped<IReceiptRepository, ReceiptRepository>().AddScoped<IUserRepository, UserRepository>().AddScoped<IAdminRepository,AdminRepository>().AddScoped<ISuplierRepository,SuplierRepository>().AddScoped<IInboxRepository,InboxRepository>().BuildServiceProvider();


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


        /// <summary>
        /// Bana user repository içeriğini getirir.
        /// </summary>      
        public IUserRepository GetUserRepositoryInstance()
        {
            return serviceProvider.GetRequiredService<IUserRepository>();
        }

        /// <summary>
        /// Bana Admin repository içeriğini getirir.
        /// </summary>      
        public IAdminRepository GetAdminRepositoryInstance()
        {
            return serviceProvider.GetRequiredService<IAdminRepository>();
        }

        /// <summary>
        /// Bana suplier repository içeriğini getirir.
        /// </summary>     
        public ISuplierRepository GetSuplierRepositoryInstance()
        {
            return serviceProvider.GetRequiredService<ISuplierRepository>();
        }

        /// <summary>
        /// Bana Inbox repository içeriğini getirir.
        /// </summary>        
        public IInboxRepository GetInboxRepositoryInstance()
        {
            return serviceProvider.GetRequiredService<IInboxRepository>();
        }



    }
}
