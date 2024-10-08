﻿using Microsoft.Extensions.DependencyInjection;
using SolarLab.Academy.AppServices.User.Repository;
using SolarLab.Academy.AppServices.User.Services;
using SolarLab.Academy.AppServices.WeatherForecast.Services;
using SolarLab.Academy.DataAccess.FakeDB;

namespace SolarLab.Academy.ComponentRegistrar
{
    public static class ComponentRegistrar
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddTransient<IWeatherForecastService, WeatherForecastService>();
            services.AddTransient<IUserService, UserService>();
            
            //FAKE REPO
            services.AddSingleton<IUserRepository, UserRepository>();
            
            return services;
        }
    }
}