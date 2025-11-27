using HepsiSln.Application.DTOs;
using HepsiSln.Application.Interfaces.AutoMappers;
using HepsiSln.Application.Interfaces.UnitofWoks;
using HepsiSln.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiSln.Application.Features.Products.Queries.GetAllProducts
{
    // aradaki işlelmeler hanflerda yapılır 
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQueryRequest, IList<GetAllProductsQueryResponse>>
    {
        private readonly IUnitofWork unitofWork;
        private readonly IMapper mapper;

        public GetAllProductsQueryHandler(IUnitofWork unitofWork,IMapper mapper)
        {
            this.unitofWork = unitofWork;
            this.mapper = mapper;
        }

        

        async Task<IList<GetAllProductsQueryResponse>> IRequestHandler<GetAllProductsQueryRequest, IList<GetAllProductsQueryResponse>>.Handle(GetAllProductsQueryRequest request, CancellationToken cancellationToken)
        {
            
            var products = await unitofWork.GetReadRepository<Product>().GetAllAsync(include:x=>x.Include(b=>b.Brand));

            var brand= mapper.Map<BrandDto,Brand>(new Brand());
         
            var map = mapper.Map<GetAllProductsQueryResponse,Product>(products);
            foreach (var item in map)
                item.Price -= (item.Price * item.Discount / 100);
            return map;
        }
    }
}
