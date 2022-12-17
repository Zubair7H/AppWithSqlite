using AppWithSqlite.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWithSqlite.Gateway
{
    public class CustomerGateway
    {
        ApplicationDBcontext _dbContext2 = new ApplicationDBcontext();

        public bool Add (Customer customer)
        {
            _dbContext2.customers.Add(customer);
            return _dbContext2.SaveChanges()>0;
        }
        public List<Customer> GetAll()
        {
            return _dbContext2.customers.ToList();
        }
        public bool Update(Customer customer)
        {
            var data = _dbContext2.customers.FirstOrDefault(c => c.CustomerId == customer.CustomerId);
            if (data == null)
            {
                return false;
            }
            data.Cname = customer.Cname;
            data.Email = customer.Email;
            data.Cnumber = customer.Cnumber;
            data.Caddress = customer.Caddress;

            return _dbContext2.SaveChanges() > 0;
        }
        public bool Delete(int id)
        {
            var customer = _dbContext2.customers.FirstOrDefault(s => s.CustomerId == id);
            if (customer == null)
            {
                return false;
            }
            _dbContext2.customers.Remove(customer);
            return _dbContext2.SaveChanges() > 0;
        }
    }
}
