namespace Ecommerce.Models.Catalogs
{
    public class Catalog
    {
        private List<Product> Products = new();
        private List<Category> Categories = new();
        private List<Brand> Brands = new();
        private List<Cluster> Clusters = new();

        public List<Product> GetProducts => Products;
        public List<Category> GetCategories => Categories;
        public List<Brand> GetBrands => Brands;
        public List<Cluster> GetClusters => Clusters;
        public Product GetProductById(int id) => Products.First(p => p.Id.Equals(id));

        public bool TryAddProduct(Product product)
        {
            try
            {
                product.Validate(this);
                Products.Add(product);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool TryAddCategory(Category category)
        {
            try
            {
                category.Validate(this);
                Categories.Add(category);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool TryAddBrand(Brand brand)
        {
            try
            {
                brand.Validate(this);
                Brands.Add(brand);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool TryAddCluster(Cluster cluster)
        {
            try
            {
                cluster.Validate(this);
                Clusters.Add(cluster);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
