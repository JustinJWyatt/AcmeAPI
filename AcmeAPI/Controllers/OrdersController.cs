using Microsoft.AspNetCore.Mvc;
using AcmeAPI.Models;
using AcmeAPI.Services;
using AcmeAPI.Utilities;

namespace AcmeAPI.Controllers
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