using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWithSqlite
{
    public static class AppCon
    {
        public static string ConnectionString => ConfigurationManager.ConnectionStrings["DB"].ConnectionString;

    }
}
