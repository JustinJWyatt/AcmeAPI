using Microsoft.AspNetCore.Mvc;
using Acme.API.Models;
using Acme.API.Services;
using Acme.API.Utilities;

namespace Acme.API.Controllers
{
    [ApiKey]
    [Route("[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IAcmeService _acmeService;

        public OrdersController(IAcmeService acmeService)
        {
            _acmeService = acmeService;
        }

        [HttpGet]
        public IEnumerable<Order> Get()
        {
            return _acmeService.GetOrders();
        }

        [HttpGet("{id}")]
        public Order Get(int id)
        {
            return _acmeService.GetOrder(id);
        }

        [HttpPost]
        public void Post([FromBody] Order value)
        {
            _acmeService.CreateOrder(value);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Order value)
        {
            _acmeService.UpdateOrder(id, value);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _acmeService.DeleteOrder(id);
        }
    }
}