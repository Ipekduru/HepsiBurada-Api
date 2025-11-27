using HepsiSln.Application.Interfaces.UnitofWoks;
using HepsiSln.Domain.Entities;
using MediatR;
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

        public GetAllProductsQueryHandler(IUnitofWork unitofWork)
        {
            this.unitofWork = unitofWork;
        }



        async Task<IList<GetAllProductsQueryResponse>> IRequestHandler<GetAllProductsQueryRequest, IList<GetAllProductsQueryResponse>>.Handle(GetAllProductsQueryRequest request, CancellationToken cancellationToken)
        {
            var products = await unitofWork.GetReadRepository<Product>().GetAllAsync();


            List<GetAllProductsQueryResponse> response = new();
            foreach (var product in products)
            {
                response.Add(new GetAllProductsQueryResponse
                {
                    Title = product.Title,
                    Description = product.Description,
                    Discount = product.Discount,
                    Price = product.Price-(product.Price*product.Discount/100)
                });
            }
            return response;
        }
    }
}
