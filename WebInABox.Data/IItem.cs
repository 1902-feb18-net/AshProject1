using System;
using System.Collections.Generic;
using System.Text;
using WebInABox.Core;

namespace WebInABox.Data
{
    interface IItem
    {
        //available methods
        IEnumerable<Item> ItemByName(string name);
        Item GetById(int id);
        Item Update(Item updatedItem);
        Item Add(Item newItem);
        int Commit();



    }
}
