using FluentValidation;
using HepsiSln.Application.Bases;
using HepsiSln.Application.Behaviours;
using HepsiSln.Application.Exceptions;
using HepsiSln.Application.Features.Products.Rules;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Globalization;
using System.Reflection;


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

            //// rule işlemlerinin hepsini traisent işlemine tabii tutmam gereklidir 
            //services.AddTransient<ProductRules>();
            services.AddRulesFromAssembşyContaining(assembly, typeof(BaseRules));

            services.AddValidatorsFromAssembly(assembly);
            ValidatorOptions.Global.LanguageManager.Culture = new CultureInfo("tr");


            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(FluentValidationBehaviour<,>));


        }
        private static IServiceCollection AddRulesFromAssembşyContaining(this IServiceCollection services,
            Assembly assembly,
            Type type)
        {
            var types = assembly.GetTypes().Where(t => t.IsSubclassOf(type) && type != t).ToList();

            foreach (var item in types)
                services.AddTransient(item);

            return services;
        }
    }
}
