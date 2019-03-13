using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebInABox.Core;
using WebInABox.Data;

namespace WebInABox.Pages.Customers
{
    public class CustomerEditModel : PageModel
    {
        private readonly ICustomerData customerData;
        private readonly IHtmlHelper htmlHelper;

        [BindProperty]
        public Customer Customer { get; set; }

        public CustomerEditModel(ICustomerData customerData,
                        IHtmlHelper htmlHelper)
        {
            this.customerData = customerData;
            this.htmlHelper = htmlHelper;
        }


        public void OnGet()
        {

        }
    }
}