using HepsiSln.Application.Interfaces.UnitofWoks;
using HepsiSln.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiSln.Application.Features.Products.Commands.CreateProduct
{
    public class CreateProductsCommandHandler
        : IRequestHandler<CreateProductsCommandRequest, Unit>
    {
        private readonly IUnitofWork unitofWork;

        public CreateProductsCommandHandler(IUnitofWork unitofWork)
        {
            this.unitofWork = unitofWork;
        }
        public async Task<Unit> Handle(CreateProductsCommandRequest request, CancellationToken cancellationToken)
        {
            Product product = new(request.Title, request.Description, request.BrandId, request.Price, request.Discount);
            await unitofWork.GetWriteRepository<Product>().AddAsync(product);


            if (await unitofWork.SaveAsync() > 0)
            {
                //result değerim yapılan işlem sayısını verir 
                foreach (var categoryId in request.CategoryIds)
                    await unitofWork.GetWriteRepository<ProductCategory>().AddAsync(new()
                    {
                        ProductId = product.Id,
                        CategorytId = categoryId
                    });

                await unitofWork.SaveAsync();
            }
            return Unit.Value;


        }
    }
}
