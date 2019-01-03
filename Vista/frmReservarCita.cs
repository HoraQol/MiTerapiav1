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
using Modelo;

namespace Vista
{
    public partial class frmReservarCita : Form
    {
        private int idClienteSelec;
        public frmReservarCita()
        {
            InitializeComponent();
            int rowId = dgvSesiones.Rows.Add();
            DataGridViewRow row = dgvSesiones.Rows[rowId];
            row.Cells["colHora"].Value = "SAB 29/12/18 04:00 COT";
            row.Cells["colTerap"].Value = "Juan Perez-García";
            rowId = dgvSesiones.Rows.Add();
            row = dgvSesiones.Rows[rowId];
            row.Cells["colHora"].Value = "SAB 05/01/19 04:00 COT";
            row.Cells["colTerap"].Value = "María D'Onofrio";
            cboTipo.SelectedIndex = 0;
            idClienteSelec = 0;
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hand,
            int wmsg, int wparam, int lparam);
        private void setCliente(Cliente cli)
        {
            if (cli != null)
            {
                txtDNI.Text = cli.NumDocIdent.ToString();
                txtNombre.Text = cli.ApPat.ToUpper() + " " + cli.ApMat.ToUpper() + ", " + cli.Nombre;
                switch (cli.Categ)
                {
                    case 1:
                        txtCateg.Text = "Niño";
                        break;
                    case 2:
                        txtCateg.Text = "Adolescente";
                        break;
                    case 3:
                        txtCateg.Text = "Adulto";
                        break;
                }
                idClienteSelec = cli.Id;
            }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLimpiarCliente_Click(object sender, EventArgs e)
        {
            txtDNI.Text = "";
            txtNombre.Text = "";
            txtCateg.Text = "";
            idClienteSelec = 0;
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            frmBuscarCliente frm = new frmBuscarCliente();
            frm.ShowDialog();
            setCliente(frm.getCliente());
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
                CustomMessageBox frm = new CustomMessageBox("No puede eliminar una sesión de una lista vacía.",
                    "Error en la transacción", 1);
                frm.ShowDialog();
            }
        }

        private void btnHorarios_Click(object sender, EventArgs e)
        {
            frmVerHorarios frm = new frmVerHorarios();
            frm.ShowDialog();
        }

        private void chkPagador_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void cboTipo_TextChanged(object sender, EventArgs e)
        {
            if (cboTipo.SelectedIndex > 0)
            {
                label10.Visible = true;
                txtNumDoc.Visible = true;
            }
            else
            {
                label10.Visible = false;
                txtNumDoc.Visible = false;
            }
        }

        private void chkPagador_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkPagador.Checked)
            {
                txtPagador.Enabled = true;
                txtPagador.Text = "";
            }
            else
            {
                txtPagador.Enabled = false;
                txtPagador.Text = txtNombre.Text;
            }
        }

        private void dgvSesiones_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                int conta = 0, i = 0;
                var senderGrid = (DataGridView)sender;
                foreach (DataGridViewRow row in senderGrid.Rows)
                {
                    //DataGridViewCheckBoxCell cel = (row.Cells[2] as DataGridViewCheckBoxCell);
                    if (Convert.ToBoolean(row.Cells[2].Value))
                        conta++;
                    if (!(Convert.ToBoolean(row.Cells[2].Value)) && (e.RowIndex == i))
                        conta++;
                    i++;
                }
                txtNumSesiones.Text = conta.ToString();
                txtTotal.Text = (conta * 45.00).ToString("n2");
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            CustomMessageBox frm = new CustomMessageBox("El registro se realizó satisfactoriamente.",
                    "Registro correcto", 1);
            frm.ShowDialog();
            Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CustomMessageBox frm = new CustomMessageBox("¿Está seguro de cancelar este registro?",
                    "Mensaje de confirmación", 1);
            frm.ShowDialog();
            if (frm.getEstado() == 1)
                Dispose();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int conta = 0, i = 0;
            foreach (DataGridViewRow row in dgvSesiones.Rows)
            {
                if (Convert.ToBoolean(row.Cells[2].Value))
                conta++;
                i++;
            }
            txtNumSesiones.Text = conta.ToString();
            txtTotal.Text = (conta * 45.00).ToString("n2");
            btnRegistrar.Enabled = true;
        }

        private void dgvSesiones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
                btnRegistrar.Enabled = false;
        }
    }
}
