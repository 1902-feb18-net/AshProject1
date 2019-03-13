using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using WebInABox.Core;
using WebInABox.Data;

namespace WebInABox.Pages.Customers
{
    public class CustomerListModel : PageModel //will perform data access
    {
        private readonly IConfiguration config;
        private readonly ICustomerData custmerData;

        public string Message { get; set; }
        public IEnumerable<Customer> Customers { get; set; }

        public CustomerListModel(IConfiguration config, ICustomerData custmerData)
        {
            this.config = config;
            this.custmerData = custmerData;
        }

        public void OnGet(string searchTerm)
        {
            Message = config["Message"];
            Customers = custmerData.GetCustomersByName(searchTerm);
        }
    }
}