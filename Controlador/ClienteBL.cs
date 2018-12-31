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
    public class ClienteBL
    {
        private ClienteDA adminCliente;
        public ClienteBL()
        {
            adminCliente = new ClienteDA();
        }
        public bool registrarCliente(Cliente cliente)
        {
            return adminCliente.registrarCliente(cliente);
        }
        public BindingList<Cliente> obtenerLista()
        {
            return adminCliente.obtenerLista();
        }
    }
}
