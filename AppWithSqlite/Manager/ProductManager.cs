using AppWithSqlite.Gateway;
using AppWithSqlite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWithSqlite.Manager
{
    public class ProductManager
    {
        ProductGateway _productGateway = new ProductGateway();

        public bool Add(Product product)
        {
            return _productGateway.Add(product);
        }
        public List<Product> GetAll()
        {
            return _productGateway.GetAll();
        }
        public bool Update(Product product)
        {
            return _productGateway.Update(product);
        }
        public bool Delete(int id)
        {
            return _productGateway.Delete(id);
        }
    }
}
