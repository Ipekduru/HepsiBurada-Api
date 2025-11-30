using HepsiSln.Application.Interfaces.Repositories;
using HepsiSln.Application.Interfaces.UnitofWoks;
using HepsiSln.Domain.Entities;
using HepsiSln.Persistence.Context;
using HepsiSln.Persistence.Repository;
using HepsiSln.Persistence.UnitofWorks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiSln.Persistence
{
    public static class Registration
    {
        //DEPENDENCY INJECTION 

        // Yani projede kullanacağın sınıfları, interface-sınıf eşleşmelerini,
        // DbContext’i, repository’leri vb. servis olarak sisteme tanıtmaya “registration” denir.
       
        // configurationn kullanılmasının sebebi connectionstringi (local olarak bağlanabileciğimiz ) bellirttik bunu program.cs içeriisnde değil de başka yerde çekebilemk için 
        public static void AddPresistence(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(opt => 
            opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped(typeof(IReadRepository<>), typeof(ReadRepository<>));
            services.AddScoped(typeof(IWriteRepository<>), typeof(WriteRepository<>));


            //UNIT OF WORK 
            services.AddScoped<IUnitofWork, UnitofWork>();

            services.AddIdentityCore<User>(opt=>
            {
                opt.Password.RequireNonAlphanumeric = false;
                opt.Password.RequiredLength = 2;
                opt.Password.RequireLowercase = false;
                opt.Password.RequireUppercase = false;
                opt.Password.RequireDigit = false;
                opt.SignIn.RequireConfirmedEmail = false;
            }).AddRoles<Role>().AddEntityFrameworkStores<AppDbContext>();
        }
    }
}
