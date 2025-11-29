using HepsiSln.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiSln.Application.Interfaces.Repositories
{
    public interface IWriteRepository<T> where T : class,IEntityBase,new()
    {
        // ben bir taskın düzgün bir şekilde gerçekleşip gerçekleşmediğini görmek istiyorsam 
        // save işlemi yaptıktan sonra gidip bu save işleminin birden küçük olup olmadığını kontrol
        // ederek o işlemin gerçekleşip gerçekleşmediğini anlarz
        Task AddAsync(T entity);
        
        //Herhanagi bir hata aldığımda hiçbirini eklemeden devam et 
        Task AddRangeAsync(IList<T> entities);
        Task<T> UpdateAsync(T entity);
        Task HardDeleteAsync(T entity);
        Task HardDeleteRangeAsync(IList<T> entity);
        Task SoftDeleteAsync(T entity);
    
    }
}
