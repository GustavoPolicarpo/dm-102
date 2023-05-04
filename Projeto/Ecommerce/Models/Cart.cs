namespace Ecommerce.Models
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
    }
}