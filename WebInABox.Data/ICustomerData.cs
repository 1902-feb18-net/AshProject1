using System.Collections.Generic;
using System.Text;
using WebInABox.Core;


namespace WebInABox.Data
{

    public interface ICustomerData
    {

        IEnumerable<Customer> GetCustomersByName(string name);
        Customer GetById(int id);
        Customer Update(Customer updatedCustomer);
        Customer Add(Customer newCustomer);
        Customer Delete(int id);
        int Commit();

    }
    //add new class thru interface
    //public class CustomerData : ICustomerData
    // {
    // }
    //select CustomerData then select Move type to CustomerData.cs (its own file)
}
