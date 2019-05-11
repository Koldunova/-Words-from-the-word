using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day22
{
    class DBUtils
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "localhost";
            int port = 3306;
            string database = "teachdiary";
            string username = "root";
            string password = "6784439";

            return DBMySQLUtils.GetDBConnection(host, port, database, username, password);
        }
    }
}
