using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; // Para mover la ventana con la barra de título

namespace Vista
{
    public partial class frmMenuGerente : Form
    {
        public frmMenuGerente()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hand, int wmsg, 
            int wparam, int lparam);

        public void AbrirForm(Object childForm)
        {
            Form child = childForm as Form;
            child.TopLevel = false;
            child.Dock = DockStyle.Fill;
            if (this.panelContenedor.Controls.Count > 0)
            {
                CustomMessageBox frm = new CustomMessageBox("Primero debe cerrar la ventana que tiene abierta," +
                    " antes de poder abrir otra.", "Mensaje de advertencia", 1);
                frm.ShowDialog();
            }
            else
            {
                this.panelContenedor.Controls.Add(child);
                this.panelContenedor.Tag = child;
                child.Show();
            }
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            if(btnReporte.Location.Y == 150)
            {
                btnListaReservas.Location = new Point(40,150);
                btnCrearReserva.Location = new Point(40,180);
                btnListaReservas.Visible = true;
                btnCrearReserva.Visible = true;
                btnReporte.Location = new Point(0, 210);
                if (btnReporteDiario.Location.Y == 180)
                {
                    btnReporteDiario.Location = new Point(40, 240);
                    btnReporteMensual.Location = new Point(40, 270);
                    btnReporteDiario.Visible = true;
                    btnReporteMensual.Visible = true;
                }
                else
                {
                    btnReporteDiario.Location = new Point(40, 210);
                    btnReporteMensual.Location = new Point(40, 210);
                    btnReporteDiario.Visible = false;
                    btnReporteMensual.Visible = false;
                }
            }
            else
            {
                btnListaReservas.Location = new Point(40, 120);
                btnCrearReserva.Location = new Point(40, 120);
                btnListaReservas.Visible = false;
                btnCrearReserva.Visible = false;
                btnReporte.Location = new Point(0, 150);
                if (btnReporteDiario.Location.Y == 240)
                {
                    btnReporteDiario.Location = new Point(40, 180);
                    btnReporteMensual.Location = new Point(40, 210);
                    btnReporteDiario.Visible = true;
                    btnReporteMensual.Visible = true;
                }
                else
                {
                    btnReporteDiario.Location = new Point(40, 150);
                    btnReporteMensual.Location = new Point(40, 150);
                    btnReporteDiario.Visible = false;
                    btnReporteMensual.Visible = false;
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Dispose();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRestaurar.Visible = true;
            btnMaximizar.Visible = false;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            btnCerrar_Click(sender, e);
        }

        private void btnCrearReserva_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmReservarCita());
        }

        private void btnListaReservas_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmListaReservas());
        }

        private void btnReporteDiario_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmReporteDiario());
        }

        private void btnReporteMensual_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmReporteMensual());
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            if (btnReporte.Location.Y == 150)
            {
                if (btnReporteDiario.Location.Y == 150)
                {
                    btnReporteDiario.Location = new Point(40, 180);
                    btnReporteMensual.Location = new Point(40, 210);
                    btnReporteDiario.Visible = true;
                    btnReporteMensual.Visible = true;
                }
                else {
                    btnReporteDiario.Location = new Point(40, 150);
                    btnReporteMensual.Location = new Point(40, 150);
                    btnReporteDiario.Visible = false;
                    btnReporteMensual.Visible = false;
                }
            }
            else
            {
                if (btnReporteDiario.Location.Y == 210)
                {
                    btnReporteDiario.Location = new Point(40, 240);
                    btnReporteMensual.Location = new Point(40, 270);
                    btnReporteDiario.Visible = true;
                    btnReporteMensual.Visible = true;
                }
                else
                {
                    btnReporteDiario.Location = new Point(40, 210);
                    btnReporteMensual.Location = new Point(40, 210);
                    btnReporteDiario.Visible = false;
                    btnReporteMensual.Visible = false;
                }
            }
        }
    }
}
