using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using WebInABox.Core;
using WebInABox.Data;

namespace WebInABox.Pages.Products
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration config;
        private readonly IProductData productData;

        public string Message { get; set; }
        public IEnumerable<Product>Products { get; set; }

        [BindProperty(SupportsGet =true)]
        public string SearchTerm { get; set; }

        public ListModel(IConfiguration config, 
                        IProductData productData)
        {
            this.config = config;
            this.productData = productData;
        }

        public void OnGet()
        {

            
            Message = config["Message"];
            Products = productData.GetProductsByName(SearchTerm);
        }
    }
}