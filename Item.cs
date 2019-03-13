using System;
using System.Collections.Generic;
using System.Text;

namespace WebInABox.Core
{
    public class Item
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public string Genre { get; set; }
        public int ItemQuantity { get; set; }
        public float ItemCost { get; set; }
        //FK property is nullable, item can exist without relationship to Product
        public int? ProductId { get; set; }
        


    }
}
