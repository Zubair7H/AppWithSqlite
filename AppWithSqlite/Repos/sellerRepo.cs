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

        public IEnumerable<AvgSallary> GetSellers()
        {
            using IDbConnection db= new SqliteConnection(AppCon.ConnectionString);
            if (db.State == ConnectionState.Closed)
                db.Open();
            return db.Query<AvgSallary>("SELECT     ID  ,     Name,     Sallary FROM    Seller WHERE    Sallary> (SELECT             AVG(Sallary)       FROM           seller           where ID=ID);", commandType: CommandType.Text);

        }

        public bool Insert(AvgSallary avgSallary)
        {
            throw new NotImplementedException();
        }

        public bool Update(AvgSallary avgSallary)
        {
            throw new NotImplementedException();
        }
    }
}
