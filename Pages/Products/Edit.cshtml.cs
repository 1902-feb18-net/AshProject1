using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebInABox.Core;
using WebInABox.Data;

namespace WebInABox.Pages.Products
{
    //  EDIT PAGE AND CREATE PAGE FOR PRODUCTS - has methods for both editing and creating
    public class EditModel : PageModel
    {
        private readonly IProductData productData;
        private readonly IHtmlHelper htmlHelper;

        [BindProperty]
        public Product Product { get; set; }
        public IEnumerable<SelectListItem> Categories { get; set; }

        public EditModel(IProductData productData,
                        IHtmlHelper htmlHelper)
        {
            this.productData = productData;
            this.htmlHelper = htmlHelper;
        }

        public IActionResult OnGet(int? productId) //OnGet responds to a Get response from User - POST will take the info and save it in a data source
        {
            Categories = htmlHelper.GetEnumSelectList<Category>();
            if (productId.HasValue)
            {
                Product = productData.GetById(productId.Value);
            }
            else
            {
                Product = new Product();
            }
            
            if(Product == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                Categories = htmlHelper.GetEnumSelectList<Category>();
                return Page();

                
            }

            if(Product.Id > 0)
            {
                productData.Update(Product);
            }
            else
            {
                productData.Add(Product); productData.Commit();
            }
            
            productData.Commit();
            TempData["Message"] = "Product Saved";
            return RedirectToPage("./Detail", new { productId = Product.Id });

        }


    }
}