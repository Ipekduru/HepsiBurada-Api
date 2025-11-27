using HepsiSln.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiSln.Application.Features.Products.Queries.GetAllProducts
{
    // kullanıcıya dönen veriler dto ve viiewmodel ile aynıdır 
    public class GetAllProductsQueryResponse
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
       //mapleme işlemi sırasında ismini brand olarak bilir 
        public BrandDto Brand { get; set; }
    }
}
