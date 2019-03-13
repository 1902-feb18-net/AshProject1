using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WebInABox.Core
{

    public class Product
    {
        public Product()
        {
            //constructor added so i dont have to remember to instantiate my lists
            //when adding new items to them
            Orders = new List<Order>();
            Locations = new List<Location>();

        }

        public int Id { get; set; }
        [Required]
        public string ProductName { get; set; }
        public string Location { get; set; }
        public float Price { get; set; }
        public Category Category { get; set; }

        public List<Order> Orders { get; set; }
        public List<Location> Locations { get; set; }
        //one to one relationship to Item class
        public Item Item { get; set; }
    }
}
