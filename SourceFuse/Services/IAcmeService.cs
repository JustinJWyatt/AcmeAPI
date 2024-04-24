using SourceFuse.Models;

namespace SourceFuse.Services
{
    public interface IAcmeService
    {
        public IEnumerable<Order> GetOrders();
        public IEnumerable<Product> GetProducts();
        public IEnumerable<Customer> GetCustomers();
        public Order GetOrder(int id);
        public Customer GetCustomer(int id);
        public Product GetProduct(int id);
        public void DeleteOrder(int id);
        public void DeleteCustomer(int id);
        public void DeleteProduct(int id);
        public void CreateOrder(Order order);
        public void CreateProduct(Product product);
        public void CreateCustomer(Customer customer);
        public void UpdateOrder(int id, Order order);
        public void UpdateProduct(int id, Product product);
        public void UpdateCustomer(int id, Customer customer);
    }
}
