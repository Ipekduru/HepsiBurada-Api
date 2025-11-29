using HepsiSln.Application.Interfaces.AutoMappers;
using HepsiSln.Application.Interfaces.UnitofWoks;
using HepsiSln.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiSln.Application.Features.Products.Commands.UpdateProduct
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommandRequest>
    {
        private readonly IUnitofWork unitofWork;
        private readonly IMapper mapper;

        public UpdateProductCommandHandler(IUnitofWork unitofWork,IMapper mapper)
        {
            this.unitofWork = unitofWork;
            this.mapper = mapper;
        }
        public async Task Handle(UpdateProductCommandRequest request, CancellationToken cancellationToken)
        {
            var product = await unitofWork.GetReadRepository<Product>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);
          
            
            // tür dönüşümü yapıldı 
            var map = mapper.Map<Product, UpdateProductCommandRequest>(request);
           
            
            
            var productCateegories = await unitofWork.GetReadRepository<ProductCategory>().
                GetAllAsync(x => x.ProductId == product.Id);// product ıd ne ise ona ait olan tüm product categorysi getir 

            await unitofWork.GetWriteRepository<ProductCategory>()
                .HardDeleteRangeAsync(productCateegories);
            foreach (var categoryId in request.CategoryIds)
                await unitofWork.GetWriteRepository<ProductCategory>()
                    .AddAsync(new() { CategorytId = categoryId, ProductId = product.Id });

            await unitofWork.GetWriteRepository<Product>().UpdateAsync(map);
            await unitofWork.SaveAsync();
            
        }
    }
}
