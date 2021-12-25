using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yulya
{
    class DB
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "192.168.4.9";
            int port = 3311;
            string database = "user3_db";
            string username = "user3";
            string password = "1234";

            return DBUtils.GetDBConnection(host, port, database, username, password);
        }
        
            
    

    }
}
