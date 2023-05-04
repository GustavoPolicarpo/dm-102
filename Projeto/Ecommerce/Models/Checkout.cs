namespace Ecommerce.Models
{
    public class Checkout
    {
        private List<Order> Orders { get; set; } = new();

        private List<Cart> ActiveCarts { get; set; } = new();

        public void CreateOrder(Cart cart)
        {
            var order = new Order(cart);
            Orders.Add(order);
            ActiveCarts.Remove(cart);
        }

        public Cart CreateCart(Customer customer)
        {
            var cart = new Cart(customer);
            ActiveCarts.Add(cart);
            return cart;
        }

        public void ListOrders()
        {
            foreach (var order in Orders)
            {
                order.PrintOrder();
            }
        }
    }
}