using FluentValidation;
using HepsiSln.Application.Behaviours;
using HepsiSln.Application.Exceptions;
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

            services.AddValidatorsFromAssembly(assembly);
            ValidatorOptions.Global.LanguageManager.Culture=new CultureInfo("tr");


            services.AddTransient(typeof(IPipelineBehavior<,>),typeof(FluentValidationBehaviour<,>));
        }
    }
}
