using AppWithSqlite.Gateway;
using AppWithSqlite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWithSqlite.Manager
{
    public class SellerManager
    {
        SellerGateway _sellerGateway=new SellerGateway();

        public bool Add(Sellers sellers)
        {
            return _sellerGateway.Add(sellers);
             
        }
        public List<Sellers> GetAll()
        {
            return _sellerGateway.GetAll();
        }
        public bool Update(Sellers sellers)
        {
            return _sellerGateway.Update(sellers);
        }
        public bool Delete(int id)
        {
            return _sellerGateway.Delete(id);
        }
    }
}
