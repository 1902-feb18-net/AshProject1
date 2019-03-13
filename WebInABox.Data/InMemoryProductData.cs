using System;
using System.Collections.Generic;
using WebInABox.Core;
using System.Linq;

namespace WebInABox.Data
{
    public class InMemoryProductData : IProductData
    {
        List<Product> products;

        public InMemoryProductData()
        {
            products = new List<Product>()
            {
                new Product {Id = 1, ProductName = "Little Box of Horrors", Location = "New York", Price = 25, Category = Category.Horror},
                new Product {Id = 2, ProductName = "Your Fantasies in a Box", Location = "California", Price = 25, Category = Category.Fantasy},
                new Product {Id = 3, ProductName = "SpaceBox", Location = "New York", Price = 25, Category = Category.Fiction},
                new Product {Id = 4, ProductName = "Whats in the Box", Location = "California", Price = 25, Category = Category.Mystery}

            };
        }

        public Product GetById(int id)
        {
            return products.SingleOrDefault(r => r.Id == id);
        }

        public Product Add(Product newProduct)
        {
            products.Add(newProduct);
            newProduct.Id = products.Max(r => r.Id) + 1;
            return newProduct;
        } 

        public Product Update(Product updatedProduct)
        {
            var product = products.SingleOrDefault(p => p.Id == updatedProduct.Id);
            if(product != null)
            {
                product.ProductName = updatedProduct.ProductName;
                product.Price = updatedProduct.Price;
                product.Category = updatedProduct.Category;
            }
            return product;
        }
        public int Commit() //method doesnt mean anything still we start using a real data source
        {
            return 0;
        }

        public IEnumerable<Product> GetProductsByName(string name = null)
        {
            return from p in products
                   where string.IsNullOrEmpty(name) || p.ProductName.StartsWith(name)
                   orderby p.ProductName
                   select p;
        }

        public Product Delete(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if(product != null)
            {
                products.Remove(product);
            }
            return product;
        }

        

    }
}
