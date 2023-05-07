using Ecommerce.Models.Catalogs.Interfaces;
using System.Text.Json;

namespace Ecommerce.Models.Catalogs
{
    public class Cluster : ICatalogEntity
    {
        public Cluster(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public void PrintDetails()
        {
            Console.WriteLine(JsonSerializer.Serialize(this));
        }

        public bool Validate(Catalog catalog)
        {
            return !catalog.GetClusters.Any(c => c.Id == Id);
        }
    }
}