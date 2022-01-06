
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PCO.Application.Interfaces;
using PCO.Application.Mappings;
using PCO.Application.Services;
using PCO.Data.Context;
using PCO.Data.Repositories;
using PCO.Domain.Interfaces;

namespace PCO.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
             options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"
            ), b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

            //MAPEAR REPOSITORIES
            services.AddScoped<IUserRepository, UserRepository>();

            //MAPEAR SERVICES
            services.AddScoped<IUserService, UserService>();
            
            services.AddAutoMapper(typeof(DomainToDTOMappingProfile));

            return services;
        }
    }
}
