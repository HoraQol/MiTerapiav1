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
        public CustomMessageBox(String contenido, String titulo)
        {
            InitializeComponent();
            lblContenido.Text = contenido;
            lblTitulo.Text = titulo;
            this.StartPosition = FormStartPosition.CenterScreen;
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
