using HepsiSln.Application.Interfaces.Repositories;
using HepsiSln.Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Quic;
using System.Text;
using System.Threading.Tasks;

namespace HepsiSln.Persistence.Repository
{
    public class ReadRepository<T> : IReadRepository<T> where T : class, IEntityBase, new()
    {
        private readonly DbContext dbContext;
        public ReadRepository(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        private DbSet<T> Table { get => dbContext.Set<T>(); }
        public async Task<IList<T>> GetAllAsync(Expression<Func<T, bool>>? predicate = null, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, bool enableTracking = false)
        {
            // bu bir sorgu daha işlene geçmemiş bir sorgudur 
            IQueryable<T> queryable = Table;
            //ef cocre sorguları takip eder update delete işlemlerinde update edilecek yerler belirtilir
            // ve sonrasında saveasync çağırıldı aslında burdaki yapıda saveasynci çağırana kadar yapılan işlemler tracking mekanizması tarafından takip edilir 
            // okuma işlemi yapılacağı için bu kısımda tracking mekanizması devre dışı bırakılır performansı daha yüksek olsun diye 

            if (!enableTracking) queryable = queryable.AsNoTracking();

            // EAGER LOADİNG
            //“Repository metoduna bir fonksiyon verebilirsin.
            //Bu fonksiyon gelen IQueryable’a Include/ ThenInclude ekleyip geri döndürür.”
            //Yani dışarıdan şu tarz bir şey gönderebilirsin: q => q.Include(x => x.Category)
            //q => q.Include(x => x.Category).ThenInclude(x => x.ParentCategory)
            //Eğer kullanıcı bir include fonksiyonu gönderdiyse, mevcut query’e bu include işlemlerini uygula.”
            if (include is not null) queryable = include(queryable);
            //bu işlem dahilinde bir where sorgusu yap ve predicateime bak ona göre veriler döner 
            if (predicate is not null) queryable = queryable.Where(predicate);
            if (orderBy is not null)
                return await orderBy(queryable).ToListAsync();

            return await queryable.ToListAsync();
        }

        publicsync Task<IList<T>> GetAllAsyncByPaging(Expression<Func<T, bool>>? predicate = null, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, bool enableTracking = false, int currentPage = 1, int pageSize = 3)
        {
            // bu bir sorgu daha işlene geçmemiş bir sorgudur 
            IQueryable<T> queryable = Table;
            
            if (!enableTracking) queryable = queryable.AsNoTracking();
            if (include is not null) queryable = include(queryable);
            if (predicate is not null) queryable = queryable.Where(predicate);
            if (orderBy is not null)
                return await orderBy(queryable).Skip((currentPage-1)*pageSize).Take(pageSize).ToListAsync();

            return await queryable.ToListAsync();
        }
        public Task<int> CountAsync(Expression<Func<T, bool>>? predicate = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> Find(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }


        public Task<IList<T>> GetAsync(Expression<Func<T, bool>>? predicate, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null, bool enableTracking = false)
        {
            throw new NotImplementedException();
        }
    }
}
