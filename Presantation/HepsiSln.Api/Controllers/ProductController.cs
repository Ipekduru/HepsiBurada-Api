using HepsiSln.Application.Features.Products.Commands.CreateProduct;
using HepsiSln.Application.Features.Products.Commands.DeleteProduct;
using HepsiSln.Application.Features.Products.Commands.UpdateProduct;
using HepsiSln.Application.Features.Products.Queries.GetAllProducts;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HepsiSln.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator mediator;

        public ProductController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
           
            
            // herhangi bir request alıncaksa bu kullanılır 
            // var response = await mediator.Send(request);
            var response = await mediator.Send(new GetAllProductsQueryRequest());
            return Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> CreateAllProducts(CreateProductsCommandRequest request)
        {
          
            await mediator.Send(request);
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> DeleteProduct(DeleteProductCommandRequest request)
        {
          
            await mediator.Send(request);
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateProduct(UpdateProductCommandRequest request)
        {
          
            await mediator.Send(request);
            return Ok();
        }
    }
}
