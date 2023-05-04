namespace Ecommerce.Models
{
    public class CustomerManagement
    {
        public List<Customer> Customers { get; set; } = new();

        public Customer GetOrCreateCustomer(string name, string email, string address)
        {
            if (!Customers.Any(c => c.Name.Equals(name) && c.Email.Equals(email)))
            {
                var newCustomer = new Customer(name, email, address);
                Customers.Add(newCustomer);
            }

            return Customers.First(c => c.Name.Equals(name) && c.Email.Equals(email));
        }
    }
}