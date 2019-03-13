using System.Collections.Generic;
using WebInABox.Core;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace WebInABox.Data
{
    public class ProductData : IProductData
    {
        private readonly WebInABoxDbContext db;

        //must add product data constructor to create instance of WebInABoxDbContext.cs
        //Enter dbcontext and db parameters then create field for db
        public ProductData(WebInABoxDbContext db)
        {
            this.db = db;
        }

        public Product Add(Product newProduct)
        {
            db.Add(newProduct);
            return newProduct;
        }

        public int Commit()
        {
            return db.SaveChanges();
        }

        public Product Delete(int id)
        {
            var product = GetById(id);
            if(product != null)
            {
                db.Products.Remove(product);
            }
            return product;
        }

        public Product GetById(int id)
        {
            return db.Products.Find(id);
        }

        //make sure to add "using System.Linq to use method below
        public IEnumerable<Product> GetProductsByName(string name)
        {
            var query = from p in db.Products
                        where p.ProductName.StartsWith(name) || string.IsNullOrEmpty(name)
                        orderby p.ProductName
                        select p;
            return query;
        }

        //be sure to add "using Microsoft.EntityFrameworkCore; to use method below
        public Product Update(Product updatedProduct)
        {
            var entity = db.Products.Attach(updatedProduct);
            entity.State = EntityState.Modified;
            return updatedProduct;
        }
    }

}
