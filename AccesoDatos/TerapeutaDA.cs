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
    public class TerapeutaDA
    {
        public BindingList<Terapeuta> obtenerLista()
        {
            BindingList<Terapeuta> result = new BindingList<Terapeuta>();
            try
            {
                MySqlConnection conn = new Database().getConection();
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "SELECT * FROM miterapia.terapeuta WHERE estado = 1";
                cmd.Connection = conn;
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(new Terapeuta(reader.GetInt32("id"), reader.GetString("nombre"),
                        reader.GetString("apPat"), reader.GetString("apMat"),
                        reader.GetString("telefono"), reader.GetInt32("estado")));
                }
                conn.Close();
            }
            catch { }
            return result;
        }
    }
}
