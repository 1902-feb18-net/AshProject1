using System.Collections.Generic;
using System.Text;
using WebInABox.Core;
using Microsoft.CodeAnalysis;

namespace WebInABox.Data
{
    public interface IProductData
    {
        //available methods
        IEnumerable<Product> GetProductsByName(string name);
        Product GetById(int id);
        Product Update(Product updatedProduct);
        Product Add(Product newProduct);
        Product Delete(int id);
        int Commit();
    }
   
}
