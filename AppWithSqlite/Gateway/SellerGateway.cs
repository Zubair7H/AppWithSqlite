using AppWithSqlite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWithSqlite.Gateway
{
    public class SellerGateway
    {
        ApplicationDBcontext _dbContext = new ApplicationDBcontext();

        public bool Add(Sellers sellers)
        {
            _dbContext.Seller.Add(sellers);
            return _dbContext.SaveChanges()>0;
        }
        public List<Sellers> GetAll()
        {
            return _dbContext.Seller.ToList();
        }

        public bool Update(Sellers sellers)
        {
            var data =_dbContext.Seller.FirstOrDefault(c=>c.ID==sellers.ID);
            if (data == null)
            {
                return false;
            }
            data.Name = sellers.Name;
            data.Number = sellers.Number;
            data.Sallary = sellers.Sallary;
            return _dbContext.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var sellers= _dbContext.Seller.FirstOrDefault(s=> s.ID == id);
            if(sellers==null)
            {
                return false;
            }
            _dbContext.Seller.Remove(sellers);
            return _dbContext.SaveChanges()>0;
        }




    }

}
