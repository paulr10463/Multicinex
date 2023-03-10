using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multicinex.Classes.Conexion
{
    public class Connection
    {
        private static readonly string _connectionString = "Data Source=DESKTOP-CSTO; Initial Catalog= MulticinexSur; User ID=sa; Password=P@ssw0rd;";
        private static readonly string surServerName = "DESKTOP-CSTO";
        private static readonly string norteServerName = "DESKTOP-CSTO";

        public static string getConnectionString()
        {
            return _connectionString;
        }

        public static string getSurServerName()
        {
            return surServerName;
        }

        public static string getNorteServerName()
        {
            return norteServerName;
        }
    }
}
