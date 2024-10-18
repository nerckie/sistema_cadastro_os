using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_final
{
    class ConexaoString
    {
        string serverName = "localhost";
        string port = "5432";
        string username = "postgres";
        string password = "henrzx138";
        string dataBaseName = "trab";

        public string ConnString()
        {
            var connstring = "Server =" + serverName + ";Port = " + port + ";Username = " + username + ";Password= " + password + ";Database=" + dataBaseName + ";";

            return connstring;
        }
    }
}
