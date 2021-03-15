using Square.Application.Common.Interfaces;
using Square.Infrastructure.Persistence;
using Square.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Square.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseInMemoryDatabase("SquareDb"));

            services.AddTransient<IDateTime, DateTimeService>();
            return services;
        }
    }
}