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
        IEnumerable<AvgSallary> GetSellers();
        bool Insert(AvgSallary avgSallary);
        bool Update(AvgSallary avgSallary);
        bool Delete(string ID);

    }
}
