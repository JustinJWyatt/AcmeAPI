using Microsoft.AspNetCore.Mvc;
using SourceFuse.Models;
using SourceFuse.Services;
using SourceFuse.Utilities;

namespace SourceFuse.Controllers
{
    [ApiKey]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IAcmeService _acmeService;

        public ProductController(IAcmeService acmeService)
        {
            _acmeService = acmeService;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _acmeService.GetProducts();
        }

        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return _acmeService.GetProduct(id);
        }

        [HttpPost]
        public void Post([FromBody] Product value)
        {
            _acmeService.CreateProduct(value);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Product value)
        {
            _acmeService.UpdateProduct(id, value);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _acmeService.DeleteProduct(id);
        }
    }
}
