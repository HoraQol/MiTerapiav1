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
    public class TerapeutaBL
    {
        private TerapeutaDA adminTerap;
        public TerapeutaBL()
        {
            adminTerap = new TerapeutaDA();
        }
        public BindingList<Terapeuta> obtenerLista()
        {
            return adminTerap.obtenerLista();
        }
    }
}
