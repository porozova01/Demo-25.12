using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yulya
{
    class DBUtils
    {
        public static MySqlConnection
            GetDBConnection (string host, int port, string database, string username, string password)
        {
            string connstring = "Server = " + host + "; database = " + database + "; port = " + port + "; username = " + username + " ; password = " + password + ";";
            MySqlConnection conn = new MySqlConnection(connstring);
            return conn;
        }
    }
}
