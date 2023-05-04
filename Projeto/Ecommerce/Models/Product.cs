﻿using Ecommerce.Models.Interfaces;
using System.Text.Json;

namespace Ecommerce.Models
{
    public class Product : ICatalogEntity
    {
        public Product(int id, string name, double price, int stock, int category, int brand, HashSet<int> collections)
        {
            Id = id;
            Name = name;
            Price = price;
            Stock = stock;
            CategoryId = category;
            BrandId = brand;
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public HashSet<int> CollectionIds { get; set; } = new();

        public void PrintDetails()
        {
            Console.WriteLine(JsonSerializer.Serialize(this));
        }

        public bool Validate(Catalog catalog)
        {
            return !catalog.GetProducts.Any(p => p.Id == this.Id) &&
                catalog.GetCategories.Any(c => c.Id.Equals(this.CategoryId)) &&
                catalog.GetBrands.Any(b => b.Id.Equals(this.BrandId)) &&
                CollectionIds.All(c => catalog.GetClusters.Any(cc => cc.Id.Equals(c)));
        }
    }
}