using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBTest
{
    public static class ConnectionString
    {
        public static string MsSqlConnection => @"Server=.\SQLEXPRESS;Database=testing;Trusted_Connection=True;";
    }
}
