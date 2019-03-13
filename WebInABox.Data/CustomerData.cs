using System.Collections.Generic;
using WebInABox.Core;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace WebInABox.Data
{

    //implement interface to show all methods in interface
    //must add customer data constructor to create instance of WebInABoxDbContext.cs
    //Enter dbcontext and db parameters then create field for db

    public class CustomerData : ICustomerData
    {
        private readonly WebInABoxDbContext db;

        List<Customer> customers;
       

        public CustomerData(WebInABoxDbContext db)
        {
            this.db = db;
        }

        
        public Customer GetById(int id)
        {
            
            return customers.SingleOrDefault(r => r.Id == id);
        }

        public Customer Delete(int id)
        {
            var customer = GetById(id);
            if (customer != null)
            {
                db.Customers.Remove(customer);
            }
            return customer;

        }

        public IEnumerable<Customer> GetCustomersByName(string name)
        {
            var query = from c in db.Customers
                        where c.FirstName.StartsWith(name) || string.IsNullOrEmpty(name)
                        orderby c.FirstName
                        select c;
            return query;

        }

        

        public Customer Update(Customer updatedCustomer)
        {
            var entity = db.Customers.Attach(updatedCustomer);
            entity.State = EntityState.Modified;
            return updatedCustomer;

        }

        public Customer Add(Customer newCustomer)
        {
            db.Add(newCustomer);
            return newCustomer;
        }

        public int Commit()
        {
            return db.SaveChanges();

        }

        
    }

}
