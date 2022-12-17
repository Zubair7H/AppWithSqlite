using AppWithSqlite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AppWithSqlite.Repos
{
    public interface IProductRepository
    {
        IEnumerable<Profit> GetProduct();
        bool Insert(Profit profit);
        bool Update(Profit profit);
        bool Delete(string productID);
    }
}
