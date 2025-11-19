using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DataBase
{
    public class Connection
    {
        public static String GetConnectionString()
        {
            return "server=pabloiglesias.database.windows.net;database=PersonasDB;uid=prueba;pwd=asdlknalsdA@2131;trustServerCertificate = true;";
        }
    }
}
