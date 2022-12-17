using AppWithSqlite.Gateway;
using AppWithSqlite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWithSqlite.Manager
{
    public class SupplierManager
    {
        SupplierGateway _supplierGateway = new SupplierGateway();

        public bool Add(Supplier supplier)
        {
            return _supplierGateway.Add(supplier);

        }
        public List<Supplier> GetAll()
        {
            return _supplierGateway.GetAll();
        }
        public bool Update(Supplier supplier)
        {
            return _supplierGateway.Update(supplier);
        }
        public bool Delete(int id)
        {
            return _supplierGateway.Delete(id);
        }
    }
}
