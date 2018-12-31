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
    public partial class CustomMessageBox : Form
    {
        public CustomMessageBox(String contenido, String titulo, int nLineas)
        {
            InitializeComponent();
            lblContenido.Text = contenido;
            lblTitulo.Text = titulo;
            this.StartPosition = FormStartPosition.CenterScreen;
            setDimension(nLineas);
        }
        public void setDimension(int numLineas)
        {
            this.Size = new Size(700, (100+(numLineas-1)*13));
            this.panelContenedor.Size = new Size(700, (70 + (numLineas - 1) * 13));
            this.btnAceptar.Location = new Point(300, (40 + (numLineas - 1) * 13));
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
