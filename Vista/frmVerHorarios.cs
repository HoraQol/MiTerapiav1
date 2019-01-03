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
using Controlador;

namespace Vista
{
    public partial class frmVerHorarios : Form
    {
        private BindingList<Terapeuta> listTerap;
        public frmVerHorarios()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            llenarTerap();
            llenarHorario();
        }
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hand,
            int wmsg, int wparam, int lparam);
        public void llenarTerap()
        {
            TerapeutaBL controlTerap = new TerapeutaBL();
            listTerap = controlTerap.obtenerLista();
            for(int i=0; i<listTerap.Count; i++)
            {
                cboTerap.Items.Add(listTerap[i].ApPat.ToUpper() + " " + listTerap[i].ApMat.
                    ToUpper() + ", " + listTerap[i].Nombre);
            }
        }
        public void llenarHorario()
        {
            for (int i = 0; i < 8; i++)
            {
                dgvHorario.Rows.Add();
            }
            dgvHorario.Rows[0].Cells[0].Value = "15:00 - 15:45";
            dgvHorario.Rows[1].Cells[0].Value = "15:45 - 16:30";
            dgvHorario.Rows[2].Cells[0].Value = "16:30 - 17:15";
            dgvHorario.Rows[3].Cells[0].Value = "17:15 - 18:00";
            dgvHorario.Rows[4].Cells[0].Value = "18:00 - 18:45";
            dgvHorario.Rows[5].Cells[0].Value = "18:45 - 19:30";
            dgvHorario.Rows[6].Cells[0].Value = "19:30 - 20:15";
            dgvHorario.Rows[7].Cells[0].Value = "20:15 - 21:00";
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnIzq_Click(object sender, EventArgs e)
        {
            dtpDesde.Value = dtpDesde.Value.AddDays(-7);
            dtpHasta.Value = dtpHasta.Value.AddDays(-7);
            if(dtpDesde.Value.AddDays(-7) < dtpDesde.MinDate)
                btnIzq.Enabled = false;
        }

        private void btnDer_Click(object sender, EventArgs e)
        {
            dtpDesde.Value = dtpDesde.Value.AddDays(7);
            dtpHasta.Value = dtpHasta.Value.AddDays(7);
            if (!btnIzq.Enabled)
                btnIzq.Enabled = true;
        }

        private void cboTerap_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* Realizar consulta a base de datos */
        }
    }
}
