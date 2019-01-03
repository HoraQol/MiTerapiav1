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
    public class PagoDA
    {
        public BindingList<Pago> obtenerListaEnFecha(DateTime fecha)
        {
            BindingList<Pago> result = new BindingList<Pago>();
            try
            {
                MySqlConnection conn = new Database().getConection();
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "SELECT * FROM miterapia.pago WHERE fecha = " +
                    fecha.ToString("yyyyMMdd");
                cmd.Connection = conn;
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(new Pago(reader.GetInt32("id"), reader.GetInt32("idCita"),
                        reader.GetInt32("tipo"), reader.GetString("numDoc"),
                        reader.GetDateTime("fecha")));
                }
                conn.Close();
            }
            catch { }
            return result;
        }
    }
}
