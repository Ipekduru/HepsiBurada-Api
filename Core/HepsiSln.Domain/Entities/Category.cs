using HepsiSln.Domain.Common;
using HepsiSln.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiSln.Domain.Entities
{
    public class Category : EntityBase
    {
        public Category() { }
        public Category(int parentId, string name, int priorty)
        {
            ParentId = parentId;
            Name = name;
            Priorty = priorty;
        }
        // değişiklik için eklendi 
        int a = 0;
        public int ParentId { get; set; }
        public string Name { get; set; }
        public int Priorty { get; set; }
        public ICollection<Detail> Details { get; set; }
        // ara tablo oluşturulup oluşturulmadığını kontrol eder eğer yok ise 
        // migrationn oluştururken ara tabloyu otomatik oluşturur
        public ICollection<Product> Products { get; set; }
    }
}

