namespace Ecommerce.Models.CustomerManagements
{
    public class Customer
    {
        public Customer(string name, string email, string address)
        {
            Id = Guid.NewGuid();
            Name = name;
            Email = email;
            Address = address;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}