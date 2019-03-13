using System;
using System.Collections.Generic;
using System.Text;

namespace WebInABox.Core
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        //navigation properites below
        public Customer Customer { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}


