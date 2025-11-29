using Bogus;
using HepsiSln.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        // 🔥 Decimal Precision Tanımı (Mutlaka İlk Olarak Eklenmelidir)
        builder.Property(x => x.Price)
               .HasPrecision(18, 2);  // veya .HasColumnType("decimal(18,2)");

        builder.Property(x => x.Discount)
               .HasPrecision(5, 2);

        // Seed Data
        Faker faker = new("tr");

        Product product1 = new()
        {
            Id = 1,
            Title = faker.Commerce.ProductName(),
            Description = faker.Commerce.ProductDescription(),
            BrandId = 1,
            Discount = faker.Random.Decimal(0, 10),
            Price = faker.Finance.Amount(10, 1000),
            CreatedDate = DateTime.Now,
            IsDeleted = false
        };

        Product product2 = new()
        {
            Id = 2,
            Title = faker.Commerce.ProductName(),
            Description = faker.Commerce.ProductDescription(),
            BrandId = 3,
            Discount = faker.Random.Decimal(0, 10),
            Price = faker.Finance.Amount(10, 1000),
            CreatedDate = DateTime.Now,
            IsDeleted = false
        };

        builder.HasData(product1, product2);
    }
}
