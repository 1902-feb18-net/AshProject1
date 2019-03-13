using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WebInABox.Core
{
    public class Customer
    {
        public Customer()
        {
            Orders = new List<Order>();
        }

        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
         //many to many relationship to class Order
        public List<Order> Orders { get; set; }
        

    }

    
}
