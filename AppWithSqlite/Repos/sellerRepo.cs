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
    public class sellerRepo : ISellersRepository
    {
        public bool Delete(string ID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Sellers> GetSellers()
        {
            using IDbConnection db= new SqliteConnection(AppCon.ConnectionString);
            if (db.State == ConnectionState.Closed)
                db.Open();
            return db.Query<Sellers>("SELECT     ID  ,     Name,     Sallary FROM    Seller WHERE    Sallary> (SELECT             AVG(Sallary)       FROM           seller           where ID=ID);", commandType: CommandType.Text);

        }

        public bool Insert(Sellers sellers)
        {
            throw new NotImplementedException();
        }

        public bool Update(Sellers sellers)
        {
            throw new NotImplementedException();
        }
    }
}
