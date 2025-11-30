using HepsiSln.Application.Features.Products.Rules;
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
        private readonly ProductRules productRules;

        public CreateProductsCommandHandler(IUnitofWork unitofWork,ProductRules productRules)
        {
            this.unitofWork = unitofWork;
            this.productRules = productRules;
        }
        public async Task<Unit> Handle(CreateProductsCommandRequest request, CancellationToken cancellationToken)
        {
            IList<Product> products=  await unitofWork.GetReadRepository<Product>().GetAllAsync();
           

            await productRules.ProductTitleMustNotBeSame(products,request.Title);
          
            
            // burda bütün productlarım var 

            //if (products.Any(x => x.Title == request.Title))
            //       throw new Exception("aynı başlıkta ürün var");

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
