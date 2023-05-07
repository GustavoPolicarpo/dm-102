using Ecommerce.Models.Catalogs;
using Ecommerce.Models.CustomerManagements;
using System.Text.Json;

namespace Ecommerce.Models.Checkouts
{
    public class Cart
    {
        public Guid Id { get; set; }
        public Customer Customer { get; set; }
        public List<Product> Products { get; set; } = new();

        public Cart(Customer customer)
        {
            Id = Guid.NewGuid();
            Customer = customer;
        }

        public void AddProductToCart(Product product)
        {
            Products.Add(product);
        }

        public void RemoveProductFromCart(Product product)
        {
            Products.Remove(product);
        }

        public void CartDetails()
        {
            Console.WriteLine(JsonSerializer.Serialize(this));
        }
    }
}