using System;
using System.Collections.Generic;
using System.Text;

namespace WebInABox.Core
{
    public class Statistics
    {
        public int Id { get; set; }
        public int ProductOrdered { get; set; }
        public int OrderTax { get; set; }
        public int SingleProductsOrdered { get; set; }

        //Navigation properties
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int AddressId { get; set; }
        public ShippingAddress ShippingAddress { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

    }
}
