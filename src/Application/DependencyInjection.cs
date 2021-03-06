using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Square.Application.Common.Interfaces;
using Square.Application.Common.Rasteriser;
using System.Reflection;

namespace Square.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddTransient<PolygonRasteriser, PolygonRasteriser>();
            return services;
        }
    }
}
