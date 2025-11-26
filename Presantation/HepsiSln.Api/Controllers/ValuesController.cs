using HepsiSln.Application.Interfaces.UnitofWoks;
using HepsiSln.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HepsiSln.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IUnitofWork unitofWork;

        public ValuesController(IUnitofWork unitofWork)
        {
            this.unitofWork = unitofWork;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await unitofWork.GetReadRepository<Product>().GetAllAsync());
        }
    }
}
