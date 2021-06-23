using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using StandardsAUTest.Application.Services;
using StandardsAUTest.Domain.Interfaces;
using StandardsAUTest.Infrastructure.Persistance;

namespace StandardAUTest
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddCommonInfrastructure(configuration);

            services.AddDbContext<DataContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("Db")));

            services.AddScoped<IDataContext>(provider => provider.GetService<DataContext>());

            return services;
        }

        public static IServiceCollection AddCommonInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ICustomerService, CustomerService>();

            return services;
        }
    }
}