using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiSln.Domain.Entities
{
    // bizden bir key ister bu userları hangi tipte bir key ile tutmak istediğimizi ister verilmez ise int ile tutar
    public class User: IdentityUser<Guid>
    {
    }
}
