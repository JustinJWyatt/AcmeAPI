using SourceFuse.Models;

namespace SourceFuse.Services
{
    public class AcmeService : IAcmeService
    {
        private readonly ApplicationDbContext _context;

        public AcmeService(ApplicationDbContext context) 
        {
            _context = context;
        }

        public void CreateCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        public void CreateOrder(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }

        public void CreateProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void DeleteCustomer(int id)
        {
            var customer = GetCustomer(id);

            _context.Customers.Remove(customer);
            _context.SaveChanges();
        }

        public void DeleteOrder(int id)
        {
            var order = _context.Orders.Find(id);

            _context.Orders.Remove(order);
            _context.SaveChanges();
        }

        public void DeleteProduct(int id)
        {
            var product = _context.Products.Find(id);

            _context.Products.Remove(product);
            _context.SaveChanges();
        }

        public Customer GetCustomer(int id) => _context.Customers.Find(id);

        public IEnumerable<Customer> GetCustomers() => _context.Customers.ToList();

        public Order GetOrder(int id) => _context.Orders.Find(id);

        public IEnumerable<Order> GetOrders()
        {
            return _context.Orders.ToList();
        }

        public Product GetProduct(int id)
        {
            return _context.Products.Find(id);
        }

        public IEnumerable<Product> GetProducts()
        {
            return _context.Products.ToList();
        }

        public void UpdateCustomer(int id, Customer customer)
        {
            var _ = GetCustomer(id);
            _context.Update(_).CurrentValues.SetValues(customer);
            _context.SaveChanges();
        }

        public void UpdateOrder(int id, Order order)
        {
            var _ = GetOrder(id);
            _context.Update(_).CurrentValues.SetValues(order);
            _context.SaveChanges();
        }

        public void UpdateProduct(int id, Product product)
        {
            var _ = GetProduct(id);
            _context.Update(_).CurrentValues.SetValues(product);
            _context.SaveChanges();
        }
    }
}
