using Ecommerce.Models.Catalogs;
using Ecommerce.Models.Checkouts;
using Ecommerce.Models.CustomerManagements;

namespace Ecommerce.Models
{
    public class Store
    {
        public Store(string name)
        {
            Name = name;
        }
        public string? Name { get; set; }
        public Catalog Catalog { get; set; } = new();
        public Checkout Checkout { get; set; } = new();
        public CustomerManagement CustomerManagement { get; set; } = new();

        public void ListCatalog()
        {
            Console.WriteLine("Catalog Details");
            Console.WriteLine("Categories:");
            Catalog.GetCategories.ForEach(c => c.PrintDetails());

            Console.WriteLine("Brands:");
            Catalog.GetBrands.ForEach(c => c.PrintDetails());

            Console.WriteLine("ProductClusters:");
            Catalog.GetClusters.ForEach(c => c.PrintDetails());

            Console.WriteLine("Products:");
            Catalog.GetProducts.ForEach(c => c.PrintDetails());
        }

        public void CleanCatalog()
        {
            Catalog = new();
        }

        public void ListCheckout()
        {
            Console.WriteLine("Checkout Details");
            Console.WriteLine("Orders:");
            Checkout.ListOrders();
            Console.WriteLine("ActiveCarts:");
            Checkout.ListActiveCarts();
        }
    }
}
