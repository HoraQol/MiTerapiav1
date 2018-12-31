using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Modelo;
using MySql.Data.MySqlClient;

namespace AccesoDatos
{
    public class ClienteDA
    {
        public bool registrarCliente(Cliente cliente)
        {
            try
            {
                MySqlConnectionStringBuilder conn_string = new MySqlConnectionStringBuilder();
                conn_string.PersistSecurityInfo = true;
                conn_string.Server = "localhost";
                conn_string.UserID = "root";
                conn_string.Password = "root";
                conn_string.Database = "miterapia";
                MySqlConnection conn = new MySqlConnection(conn_string.ToString());
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "INSERT INTO miterapia.cliente (nombre, apPat, apMat, " +
                    "tipoDocIdent, numDocIdent, fechaNac,categ,telefono,estado)" +
                    "VALUES ('" + cliente.Nombre + "','" + cliente.ApPat + "','" + cliente.ApMat +
                    "','" + cliente.TipoDocIdent.ToString() + "','" + cliente.NumDocIdent + "','" +
                    (cliente.FechaNac).ToString("yyyyMMdd") + "','" + cliente.Categ.ToString() +
                    "','" + cliente.Telefono + "','" + cliente.Estado.ToString() + "')";
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                conn.Close();
            }catch(Exception e)
            {
                return false;
            }
            return true;
        }
        public BindingList<Cliente> obtenerLista()
        {
            BindingList<Cliente> result = new BindingList<Cliente>();
            try
            {
                MySqlConnectionStringBuilder conn_string = new MySqlConnectionStringBuilder();
                conn_string.PersistSecurityInfo = true;
                conn_string.Server = "localhost";
                conn_string.UserID = "root";
                conn_string.Password = "root";
                conn_string.Database = "miterapia";
                MySqlConnection conn = new MySqlConnection(conn_string.ToString());
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "SELECT * FROM miterapia.cliente WHERE estado = 1";
                cmd.Connection = conn;
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(new Cliente(reader.GetInt32("id"), reader.GetString("nombre"),
                        reader.GetString("apPat"), reader.GetString("apMat"),
                        reader.GetInt32("tipoDocIdent"), reader.GetInt32("numDocIdent"),
                        reader.GetDateTime("fechaNac"), reader.GetInt32("categ"),
                        reader.GetString("telefono"), reader.GetInt32("estado")));
                }
                conn.Close();
            }
            catch { }
            return result;
        }

    }
}
