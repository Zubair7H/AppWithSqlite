using AppWithSqlite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWithSqlite.Gateway
{
    public class ProductGateway
    {
        ApplicationDBcontext _dbContext2 = new ApplicationDBcontext();

        public bool Add(Product product)
        {
            _dbContext2.Products.Add(product);
            return _dbContext2.SaveChanges() > 0;
        }
        public List<Product> GetAll()
        {
            return _dbContext2.Products.ToList();
        }
        public bool Update(Product product)
        {
            var data = _dbContext2.Products.FirstOrDefault(c => c.productID == product.productID);
            if (data == null)
            {
                return false;
            }
            data.supplierID = product.supplierID;
            data.productName = product.productName;
            data.Brand = product.Brand;
            data.Cost = product.Cost;
            data.Price = product.Price;
            data.Type = product.Type;

            return _dbContext2.SaveChanges() > 0;
        }
        public bool Delete(int id)
        {
            var product = _dbContext2.Products.FirstOrDefault(s => s.productID == id);
            if (product == null)
            {
                return false;
            }
            _dbContext2.Products.Remove(product);
            return _dbContext2.SaveChanges() > 0;
        }
    }
}
