using HepsiSln.Application.Interfaces.AutoMappers;
using HepsiSln.Application.Interfaces.UnitofWoks;
using HepsiSln.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiSln.Application.Features.Products.Commands.DeleteProduct
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommandRequest>
    {
        private readonly IUnitofWork unitofWork;
       
        public DeleteProductCommandHandler(IUnitofWork unitofWork)
        {
            this.unitofWork = unitofWork;
            
        }
        public async Task Handle(DeleteProductCommandRequest request, CancellationToken cancellationToken)
        {
            var prodcut = await unitofWork.GetReadRepository<Product>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);
            prodcut.IsDeleted = true;
            await unitofWork.GetWriteRepository<Product>().UpdateAsync(prodcut);
            await unitofWork.SaveAsync();
        }
    }
}
