using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWithSqlite.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string? Cname { get; set; }
        public string? Email { get; set; }
        public string? Cnumber { get; set; }
        public string? Caddress { get; set; }
    }
}
