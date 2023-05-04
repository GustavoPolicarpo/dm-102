using Ecommerce.Models.Interfaces;
using System.Text;
using System.Text.Json;

namespace Ecommerce.Models
{
    public class Category : ICatalogEntity
    {
        public Category(int id, string name, string description, int? fatherCategoryId)
        {
            Id = id;
            Name = name;
            Description = description;
            FatherCategoryId = fatherCategoryId;
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int? FatherCategoryId { get; set; }

        public void PrintDetails()
        {
            Console.WriteLine(JsonSerializer.Serialize(this));
        }

        public bool Validate(Catalog catalog)
        {
            return !catalog.GetCategories.Any(x => x.Id == this.Id) &&
                (this.FatherCategoryId == null || catalog.GetCategories.Any(x => x.Id.Equals(this.FatherCategoryId)));
        }
    }
}