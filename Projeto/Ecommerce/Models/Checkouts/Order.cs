using Ecommerce.Models.Catalogs;
using Ecommerce.Models.CustomerManagements;
using System.Text.Json;

namespace Ecommerce.Models.Checkouts
{
    public class Order
    {
        public Guid Id { get; set; }
        public CustomerOrder Customer { get; set; }
        public List<ProductOrder> Products { get; set; }
        public double TotalPrice { get; set; }
        public int TotalItems { get; set; }
        public Order(Cart cart)
        {
            Id = Guid.NewGuid();
            Customer = new CustomerOrder(cart.Customer);
            Products = cart.Products.Select(p => new ProductOrder(p)).ToList();
            TotalPrice = cart.Products.Sum(p => p.Price);
            TotalItems = cart.Products.Count;
        }

        public void OrderDetails()
        {
            Console.WriteLine(JsonSerializer.Serialize(this));
        }
    }

    public class ProductOrder
    {
        public string? Name { get; set; }
        public double Price { get; set; }

        public ProductOrder(Product product)
        {
            Name = product.Name;
            Price = product.Price;
        }
    }

    public class CustomerOrder
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public CustomerOrder(Customer customer)
        {
            Name = customer.Name;
            Email = customer.Email;
            Address = customer.Address;
        }
    }
}