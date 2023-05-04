namespace Ecommerce.Models.Interfaces
{
    public interface ICatalogEntity
    {
        bool Validate(Catalog catalog);
        void PrintDetails();
    }
}
