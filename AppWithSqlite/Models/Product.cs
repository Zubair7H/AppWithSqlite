using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWithSqlite.Models
{
    public class Product
    {
        public int productID { get; set; }
        public int supplierID { get; set; }
        public string? productName { get; set; }
        public string? Brand { get; set; }

        public decimal Cost { get; set; }
        public decimal Price { get; set; }
        public string? Type { get; set; }

        //public string? Profitmargin { get; set; }
    }
}
