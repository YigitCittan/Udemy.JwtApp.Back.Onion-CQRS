using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Udemy.JwtApp.Back.Onion.Application.Interfaces;
using Udemy.JwtApp.Back.Onion.Application.Mappings;
using Udemy.JwtApp.Back.Onion.Persistance.Context;
using Udemy.JwtApp.Back.Onion.Persistance.Repositories;

namespace Onion.JwtApp.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {          
            services.AddDbContext<JwtContext>(opt => {
                opt.UseSqlServer(configuration.GetConnectionString("Local"));
            });

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
           
        }
    }
}
