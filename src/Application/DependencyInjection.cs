﻿using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Square.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
