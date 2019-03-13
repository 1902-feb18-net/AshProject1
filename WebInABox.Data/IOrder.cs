using System;
using System.Collections.Generic;
using System.Text;
using WebInABox.Core;

namespace WebInABox.Data
{
    public interface IOrder
    {


        Order GetOrderByCustomer(int id);







    }



}

//add new class thru interface
//public class CustomerData : ICustomerData
// {
// }
//select CustomerData then select Move type to CustomerData.cs (its own file)
