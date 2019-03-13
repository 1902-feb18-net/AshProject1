using System;
using System.Collections.Generic;
using System.Text;

namespace WebInABox.Core
{
    public class ShippingAddress
    {
        public ShippingAddress()
        {
            //constructor added so i dont have to remember to instantiate my lists
            //when adding new locations to them
            Locations = new List<Location>();
        }

        public int Id { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }

        public List<Location> Locations { get; set; }

    }
}
