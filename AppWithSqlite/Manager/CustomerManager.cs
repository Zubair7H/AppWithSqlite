using AppWithSqlite.Gateway;
using AppWithSqlite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWithSqlite.Manager
{
    public class CustomerManager
    {
        CustomerGateway _customerGateway = new CustomerGateway();

        public bool Add(Customer customer)
        {
            return _customerGateway.Add(customer);
        }
        public List<Customer> GetAll()
        {
            return _customerGateway.GetAll();
        }
        public bool Update(Customer customer)
        {
        return _customerGateway.Update(customer);
        }
        public bool Delete(int id)
        {
            return _customerGateway.Delete(id);
        }
    }
}
