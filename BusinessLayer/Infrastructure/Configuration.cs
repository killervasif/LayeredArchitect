using BusinessLayer.Services;
using DataAccessLayer.Repositories;
using DataAccessLayer.Repositories.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Ninject.Modules;

namespace BusinessLayer.Infrastructure
{
    public static class Configuration
    {

        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IMemberRepository, MemberRepository>();
        }

    }
}
