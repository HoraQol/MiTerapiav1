using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public class Database
    {
        private MySqlConnection conn;
        public Database()
        {
            try
            {
                MySqlConnectionStringBuilder conn_string = new MySqlConnectionStringBuilder();
                conn_string.PersistSecurityInfo = true;
                conn_string.Server = "localhost";
                conn_string.UserID = "root";
                conn_string.Password = "root";
                conn_string.Database = "miterapia";
                conn = new MySqlConnection(conn_string.ToString());
            }
            catch(Exception e) { }
        }
        public MySqlConnection getConection()
        {
            return conn;
        }
    }
}
