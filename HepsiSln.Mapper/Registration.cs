using HepsiSln.Application.Interfaces.AutoMappers;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
namespace HepsiSln.Mapper
{
    //Registration bir sınıfın dependecy injection containerına(dependency injection sistemine) tanımlanmasıdır.
    public static class Registration
    {
        public static void AddCustomMapper(this IServiceCollection services)
        {

         services.AddSingleton<IMapper, AutoMapper.Mapper>();
        }
    }
}
