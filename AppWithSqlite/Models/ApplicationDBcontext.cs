using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWithSqlite.Models
{
    public class ApplicationDBcontext:DbContext

    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlite(@"Data Source=C:\Users\alame\source\repos\AppWithSqlite\DB\BuildingMaterialDB.db");

        }
        public DbSet<Sellers> Seller { get; set; }
        public DbSet<Customer> customers { get; set; }

        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Product> Products { get; set; }
        //public DbSet<Profit> Profits { get; set; }

        public IDbConnection dbConnection()
        {
            return new SqliteConnection(@"Data Source=C:\Users\alame\source\repos\AppWithSqlite\DB\BuildingMaterialDB.db");
        }

        
    }
    
}
