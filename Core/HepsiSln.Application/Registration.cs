using HepsiSln.Application.Exceptions;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HepsiSln.Application
{
    public static class Registration
    {
        public static void AddApplication(this IServiceCollection services) 
        {
            //featuresteki tüm mediatr işlemlerini görüyor oldu 
            var assembly = Assembly.GetExecutingAssembly();
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(assembly));
            services.AddTransient<ExxceptionMiddleware>();
        }
    }
}
