using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONetLib
{
    public static class ConnectionString
    {
        //public static string MsSqlConnection = @"Server=.\SQLEXPRESS;Database=testing;User Id=DESKTOP-OK92H0G\Main;Password=admin;TrustServerCertificate=true;";

        public static string MsSqlConnection = @"Server=.\SQLEXPRESS;Database=testing;Trusted_Connection=True;TrustServerCertificate=true;Encrypt=false";
    }
}
