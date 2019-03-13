using System;
using System.Collections.Generic;
using System.Text;

namespace WebInABox.Core
{
    public class Location
    {
        public int Id { get; set; }
        public string WarehouseLocation { get; set; }

        //Navigation properties
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int AddressId { get; set; }
        public ShippingAddress ShippingAddress { get; set; }

    }
}
