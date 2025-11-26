using HepsiSln.Application.Interfaces.Repositories;
using HepsiSln.Application.Interfaces.UnitofWoks;
using HepsiSln.Persistence.Context;
using HepsiSln.Persistence.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiSln.Persistence.UnitofWorks
{
    public class UnitofWork : IUnitofWork
    {
        private readonly AppDbContext dbContext;

        public UnitofWork(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async ValueTask DisposeAsync() => await dbContext.DisposeAsync();

        public int Save() => dbContext.SaveChanges();

        public async Task<int> SaveAsync() => await dbContext.SaveChangesAsync();

        IReadRepository<T> IUnitofWork.GetReadRepository<T>() => new ReadRepository<T>(dbContext);
                                                                   //  constructorunda dbcontexti aldı 
        IWriteRepository<T> IUnitofWork.GetWriteRepository<T>() => new WriteRepository<T>(dbContext);
    }
}
