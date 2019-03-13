using System.Collections.Generic;
using WebInABox.Core;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace WebInABox.Data
{

    //implement interface to show all methods in interface
    //must add customer data constructor to create instance of WebInABoxDbContext.cs ex/(WebInABoxDbContext db)
    //Enter dbcontext and db parameters then create field for db


    public class OrderData : IOrder
    {
        private readonly WebInABoxDbContext db;

        public OrderData(WebInABoxDbContext db)
        {
            this.db = db;
        }

        public Order Add(Order newOrder)
        {
            throw new System.NotImplementedException();
        }

        public int Commit()
        {
            throw new System.NotImplementedException();
        }

        public Order Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Order GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Order> GetOrder(int id)
        {
            throw new System.NotImplementedException();
        }

        public Order Update(Order updatedOrder)
        {
            throw new System.NotImplementedException();
        }
    }





    



}


