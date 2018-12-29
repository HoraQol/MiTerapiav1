using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace Vista
{
    public partial class frmReservarCita : Form
    {
        public frmReservarCita()
        {
            InitializeComponent();
            int rowId = dgvSesiones.Rows.Add();
            DataGridViewRow row = dgvSesiones.Rows[rowId];
            row.Cells["colHora"].Value = "SAB 29/12/18 04:00 COT";
            row.Cells["colTerap"].Value = "Juan Perez-García";
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hand,
            int wmsg, int wparam, int lparam);

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLimpiarCliente_Click(object sender, EventArgs e)
        {
            txtDNI.Text = "";
            txtNombre.Text = "";
            txtCateg.Text = "";
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            frmBuscarCliente frm = new frmBuscarCliente();
            frm.ShowDialog();
        }

        private void btnCrearCliente_Click(object sender, EventArgs e)
        {
            frmCrearCliente frm = new frmCrearCliente();
            frm.ShowDialog();
        }

        private void btnEliminarHorarios_Click(object sender, EventArgs e)
        {
            if (dgvSesiones.Rows.Count > 0)
            {
                dgvSesiones.Rows.RemoveAt(dgvSesiones.CurrentCell.RowIndex);
            }
            else
            {
                CustomMessageBox frm = new CustomMessageBox("No puede eliminar una sesión de una lista vacía",
                    "Error en la transacción");
                frm.ShowDialog();
                //MessageBox.Show("No puede eliminar una sesión de una lista vacía",
                //    "Error en la transacción");
            }
        }

        private void btnHorarios_Click(object sender, EventArgs e)
        {
            frmVerHorarios frm = new frmVerHorarios();
            frm.ShowDialog();
        }
    }
}
