using HepsiSln.Domain.Common;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HepsiSln.Application.Interfaces.Repositories
{
    // veritabnı işlemlerinin yapıldığı yerdir
    public interface IReadRepository<T> where T :class,IEntityBase,new()
    {

        // predicate =null olması ısdeleted olanları alabiliriz vs 
        Task<IList<T>> GetAllAsync(Expression<Func<T, bool>>? predicate = null,
            Func<IQueryable<T>,IIncludableQueryable<T,object>>? include=null,
        Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy=null,
        bool enableTracking=false);
       
        
        // mevcut sayfadaki ilk 3 veri alınır
        Task<IList<T>> GetAllAsyncByPaging(Expression<Func<T, bool>>? predicate = null,
                              // theniclude kullanımı için eklendi çoka çok ilişkide kullanabilmek için
            Func<IQueryable<T>,IIncludableQueryable<T,object>>? include=null,
        Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy=null,
        bool enableTracking=false,int currentPage=1,int pageSize=3);

        // t tipindeki entity içinde bool döndüren koşul verebilirsin eğer vermezsen hepsini getirir 
        Task<T> GetAsync(Expression<Func<T, bool>>? predicate, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null, bool enableTracking = false);


        // predicate filtreleme ifadesidir .repositoryden verş cekerken belirli şartları sağlayanları getir 
        IQueryable<T> Find(Expression<Func<T,bool>> predicate, bool enableTraking = false);
        Task<int> CountAsync(Expression<Func<T, bool>>? predicate=null);
    }
}
