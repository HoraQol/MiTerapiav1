using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Controlador;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Vista
{
    public partial class frmBuscarCliente : Form
    {
        private ClienteBL adminCli = new ClienteBL();
        private BindingList<Cliente> listaCli = new BindingList<Cliente>();
        private Cliente clienteSelec = null;
        public frmBuscarCliente()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            listaCli = adminCli.obtenerLista();
            actualizarTabla();
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hand,
            int wmsg, int wparam, int lparam);
        public Cliente getCliente()
        {
            return clienteSelec;
        }
        public void actualizarTabla()
        {
            dgvCliente.Rows.Clear();
            for(int i=0; i< listaCli.Count; i++)
            {
                if (filtro(listaCli[i]))
                {
                    int rowId = dgvCliente.Rows.Add();
                    DataGridViewRow row = dgvCliente.Rows[rowId];
                    row.Cells["colDNI"].Value = listaCli[i].NumDocIdent;
                    row.Cells["colNombre"].Value = listaCli[i].ApPat.ToUpper() + " " +
                        listaCli[i].ApMat.ToUpper() + ", " + listaCli[i].Nombre;
                    switch (listaCli[i].Categ)
                    {
                        case 1:
                            row.Cells["colCateg"].Value = "Niño";
                            break;
                        case 2:
                            row.Cells["colCateg"].Value = "Adolescente";
                            break;
                        case 3:
                            row.Cells["colCateg"].Value = "Adulto";
                            break;
                    }
                }
            }
            btnSeleccionar.Enabled = (dgvCliente.Rows.Count > 0);
        }
        private bool filtro(Cliente cli)
        {
            // Primer filtro
            if (!((txtDNI.Text == "") || customComp(cli.NumDocIdent.ToString(), txtDNI.Text)))
                return false;
            // Segundo fitro
            if (!((txtNombre.Text == "") || (customComp(cli.ApPat.ToLower(), txtNombre.Text.ToLower())) ||
                    (customComp(cli.ApMat.ToLower(), txtNombre.Text.ToLower())) ||
                    (customComp(cli.Nombre.ToLower(), txtNombre.Text.ToLower()))))
                return false;
            return true;
        }
        private bool customComp(String c1, String c2)
        {
            for(int i=0; i<c2.Length; i++)
            {
                if (c1[i] != c2[i])
                    return false;
            }
            return true;
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            clienteSelec = null;
            this.Dispose();
        }

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDNI.Text = "";
            txtNombre.Text = "";
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            clienteSelec = listaCli[dgvCliente.CurrentCell.RowIndex];
            this.Dispose();
        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {
            actualizarTabla();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            actualizarTabla();
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            new Auxiliar.KeyPressControl().digit(sender, e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            new Auxiliar.KeyPressControl().letter(sender, e);
        }
    }
}
