using AppWithSqlite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using Microsoft.Data.Sqlite;

namespace AppWithSqlite.Repos
{
    public class ProductRepo : IProductRepository
    {
        public bool Delete(string productID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Profit> GetProduct()
        {
            using IDbConnection db = new SqliteConnection(AppCon.ConnectionString);
            if (db.State == ConnectionState.Closed)
                db.Open();
             return db.Query<Profit>("select total_purchases.productName,      (total_sales-total_cost)*100/total_sales as Profitmargin     from      (select productName,sum(Cost) as total_cost                  from Products         group by productName) as total_purchases,      (select productName,sum(Price) as total_sales      from Products          group by productName) as total_sales          where total_purchases.productName=total_sales.productName;", commandType: CommandType.Text);
        }

        public bool Insert(Profit profit)
        {
            throw new NotImplementedException();
        }

        public bool Update(Profit profit)
        {
            throw new NotImplementedException();
        }
    }
}
