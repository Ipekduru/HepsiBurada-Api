using HepsiSln.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiSln.Persistence.Configurations
{
    public class ProductCategoryConfigurations : IEntityTypeConfiguration<ProductCategory>
    {
        public int MyProperty { get; set; }

        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.HasKey(x => new { x.ProductId, x.CategorytId });
            // bire çok ilişki kuruldu 
            builder.HasOne(p => p.Product)
                .WithMany(pc => pc.ProductCategories)
                .HasForeignKey(p => p.ProductId).OnDelete(DeleteBehavior.Cascade);
           
            
            builder.HasOne(p => p.Category)
                .WithMany(pc => pc.ProductCategories)
                .HasForeignKey(p => p.CategorytId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
