using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DataBase
{
    internal class Connection
    {
        public static String GetConnectionString()
        {
            return "server=localhost;database=PersonasDB;uid=prueba;pwd=asdlknalsdA@2131;trustServerCertificate = true;";
        }
    }
}
