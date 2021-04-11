using Catalog.API.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();

            if (!existProduct)
            {
                productCollection.InsertManyAsync(GetPreConfiguredProducts());
            }
        }

        private static IEnumerable<Product> GetPreConfiguredProducts()
        {
            return new List<Product>()
        {
            new Product()
            {
                Name ="Iphone X",
                Summary ="This is the summary of product IPhone X",
                Description="Bla bla bla bla bla bla",
                ImageFile="product-1.png",
                Price = 950.00M,
                Category="Smart Phone"
            },
            new Product()
            {
                Name ="Galaxy S20",
                Summary ="This is the summary of product Galaxy S20",
                Description="Bla bla bla bla bla bla",
                ImageFile="product-2.png",
                Price = 750.00M,
                Category="Smart Phone"
            },
            new Product()
            {
                Name ="Redmi Note 10",
                Summary ="This is the summary of product Redmi Note 10",
                Description="Bla bla bla bla bla bla",
                ImageFile="product-3.png",
                Price = 550.00M,
                Category="Smart Phone"
            }
        };
        }
    }
}
