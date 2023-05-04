using Ecommerce.Models;

Console.WriteLine("");

#region cea
var cea = new Store("cea");

cea.Catalog.TryAddCategory(new Category(1, "roupa", "Departamento de roupas", null));
cea.Catalog.TryAddCategory(new Category(2, "masculina", "Roupas masculina", 1));
cea.Catalog.TryAddCategory(new Category(3, "feminina", "Roupas feminina", 1));

cea.Catalog.TryAddBrand(new Brand(1, "gucci", "Roupas Gucci"));

cea.Catalog.TryAddCluster(new Cluster(1, "luxo", "Roupas de luxo"));

cea.Catalog.TryAddProduct(new Product(1, "Camiseta Gucci M Masculina", 149.90, 5, 2, 1, new HashSet<int>() { 1 }));
cea.Catalog.TryAddProduct(new Product(2, "Camiseta Gucci P Feminina", 159.90, 3, 3, 1, new HashSet<int>() { 1 }));

cea.ListCatalog();

var ceaPolicarpo = cea.CustomerManagement.GetOrCreateCustomer("Policarpo", "gustavo.policarpo@inatel.br", "Santa Rita do Sapucai");
var ceaPaganni = cea.CustomerManagement.GetOrCreateCustomer("Policarpo", "gustavo.policarpo@inatel.br", "Santa Rita do Sapucai");

var ceaPolicarpoCart = cea.Checkout.CreateCart(ceaPolicarpo);
ceaPolicarpoCart.AddProductToCart(cea.Catalog.GetProductById(1));
var ceaPaganniCart = cea.Checkout.CreateCart(ceaPaganni);
ceaPaganniCart.AddProductToCart(cea.Catalog.GetProductById(2));

cea.Checkout.CreateOrder(ceaPolicarpoCart);

cea.ListCheckout();


#endregion

