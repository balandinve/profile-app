using Microsoft.Extensions.DependencyInjection;
using profile.data;
using profile.repository;
using profile.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace profile_app.web
{
    public static class DependencyInjection
    { public static void AddDepencyInjection(this IServiceCollection services)
        {
            services.AddScoped<AppDbContext>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<UnitOfWork>();
            services.AddScoped<ICityService, CityService>();
            services.AddScoped<IProfileService, ProfileService>();
            services.AddScoped<IProfileRepository, ProfileRepository>();
            services.AddScoped<ICityRepository, CityRepository>();
        }
    }
}
