using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Square.Application.Common.Interfaces;
using Square.Application.Common.Rasteriser;
using Square.WebUI.Services;
using System.Reflection;

namespace Square.WebUI
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<ISquareCounterService, SquareCounterService>();
            return services;
        }
    }
}
