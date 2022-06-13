using Domain.DomainServices;
using Domain.Models;
using Experienza.Application.AplicationServices;
using Experienza.Application.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Experienza.Application.DI
{
    public static class DependencyInjeccionProfile
    {
       public static IServiceCollection AddInjeccionProfile(this IServiceCollection servicesProfile)
        {
            //Application
            servicesProfile.AddTransient<IBooksAppServices,  BooksAppServices>();

            //Domain
            servicesProfile.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            return servicesProfile;
        }

        public static IServiceCollection AddInjeccionProfileMapper(this IServiceCollection servicesProfile)
        {
           return servicesProfile.AddAutoMapper(Assembly.GetExecutingAssembly());
        }

        public static IServiceCollection AddRepositoryServices(this IServiceCollection servicesProfile, IConfiguration configuration)
        {
            return servicesProfile.AddDbContext<ExperienzaDBContext>(options => 
            {
                options.UseSqlServer(configuration.GetConnectionString("DB_Connection"));
            });
            
        }
       
    }
}
