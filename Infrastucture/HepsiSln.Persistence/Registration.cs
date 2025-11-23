using HepsiSln.Persistence.Context;
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
        // Yani projede kullanacağın sınıfları, interface-sınıf eşleşmelerini,
        // DbContext’i, repository’leri vb. servis olarak sisteme tanıtmaya “registration” denir.
       
        // configurationn kullanılmasının sebebi connectionstringi (local olarak bağlanabileciğimiz ) bellirttik bunu program.cs içeriisnde değil de başka yerde çekebilemk için 
        public static void AddPresistence(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(opt => 
            opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        }
    }
}
