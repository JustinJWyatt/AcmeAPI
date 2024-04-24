using Microsoft.AspNetCore.Mvc;
using Acme.API.Models;
using Acme.API.Services;
using Acme.API.Utilities;

namespace Acme.API.Controllers
{
    [ApiKey]
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IAcmeService _acmeService;

        public CustomerController(IAcmeService acmeService) 
        {
            _acmeService = acmeService;
        }

        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return _acmeService.GetCustomers();
        }

        [HttpGet("{id}")]
        public Customer Get(int id)
        {
            return _acmeService.GetCustomer(id);
        }

        [HttpPost]
        public void Post([FromBody] Customer value)
        {
            _acmeService.CreateCustomer(value);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Customer value)
        {
            _acmeService.UpdateCustomer(id, value);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _acmeService.DeleteCustomer(id);
        }
    }
}
