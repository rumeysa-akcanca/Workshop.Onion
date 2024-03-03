using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OnionArcExample.Application.Interfaces.Repositories;
using OnionArcExample.Application.Interfaces.UnitOfWork;
using OnionArcExample.Persistence.Context;
using OnionArcExample.Persistence.Repositories;
using OnionArcExample.Persistence.UnitOfWorks;


namespace OnionArcExample.Persistence
{
    public static class ServiceRegistration
    {
        //bu katmanı kullanacak olan UI a içerideki servisleri enjekte edebilmemiz için ServiceRegistration sınıfı var.

        public static void AddPersistenceServices(this IServiceCollection serviceCollection , IConfiguration configuration=null)
        {
            serviceCollection.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("SQLConnection")));

            serviceCollection.AddTransient<IProductRepository, ProductRepository>();
            serviceCollection.AddTransient<IUnitOfWork, UnitOfWork>();
            
        }
    }
}
