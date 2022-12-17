using AppWithSqlite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWithSqlite.Repos
{
    public interface ISellersRepository
    {
        IEnumerable<Sellers> GetSellers();
        bool Insert(Sellers sellers);
        bool Update(Sellers sellers);
        bool Delete(string ID);

    }
}
