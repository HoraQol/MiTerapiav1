using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Modelo;
using AccesoDatos;

namespace Controlador
{
    public class PagoBL
    {
        private PagoDA adminPago;
        public PagoBL()
        {
            adminPago = new PagoDA();
        }
        public BindingList<Pago> obtenerLista(DateTime fecha)
        {
            return adminPago.obtenerListaEnFecha(fecha);
        }
    }
}
