namespace Ecommerce.Models.Catalogs.Interfaces
{
    public interface ICatalogEntity
    {
        bool Validate(Catalog catalog);
        void PrintDetails();
    }
}
