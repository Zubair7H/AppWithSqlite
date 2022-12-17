using AppWithSqlite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWithSqlite.Gateway
{
    public class SupplierGateway
    {
        ApplicationDBcontext _dbContext2 = new ApplicationDBcontext();

        public bool Add(Supplier supplier)
        {
            _dbContext2.Suppliers.Add(supplier);
            return _dbContext2.SaveChanges() > 0;
        }
        public List<Supplier> GetAll()
        {
            return _dbContext2.Suppliers.ToList();
        }
        public bool Update(Supplier supplier)
        {
            var data = _dbContext2.Suppliers.FirstOrDefault(c => c.supplierID == supplier.supplierID);
            if (data == null)
            {
                return false;
            }
            data.suppliername = supplier.suppliername;
            data.supplierphone = supplier.supplierphone;
          
            

            return _dbContext2.SaveChanges() > 0;
        }
        public bool Delete(int id)
        {
            var supplier = _dbContext2.Suppliers.FirstOrDefault(s => s.supplierID == id);
            if (supplier == null)
            {
                return false;
            }
            _dbContext2.Suppliers.Remove(supplier);
            return _dbContext2.SaveChanges() > 0;
        }
    }
}
