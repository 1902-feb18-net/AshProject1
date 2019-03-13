using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebInABox.Core;
using WebInABox.Data;

namespace WebInABox.Pages.Products
{
    public class DeleteModel : PageModel
    {
        private readonly IProductData productData;

        //create property of type Product
        //this gives the model that i can bind against for CSHTML file
        public Product Product { get; set; }

        public DeleteModel(IProductData productData)
        {
            this.productData = productData;
        }

        public IActionResult OnGet(int productId)
        {
            Product = productData.GetById(productId);
            if(Product == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }

        public IActionResult OnPost(int productId)
        {
            var product = productData.Delete(productId);
            productData.Commit();

            if(product == null)
            {
                return RedirectToPage("./NotFound");
            }

            TempData["Message"] = $"{product.ProductName} deleted";
            return RedirectToPage("./List");

        }

    }
}