using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmMenuGerente : Form
    {
        public frmMenuGerente()
        {
            InitializeComponent();
        }

        public void AbrirForm(Object childForm)
        {
            Form child = childForm as Form;
            child.TopLevel = false;
            child.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(child);
            this.panelContenedor.Tag = child;
            child.Show();
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmReservarCita());
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Dispose();
        }
    }
}
