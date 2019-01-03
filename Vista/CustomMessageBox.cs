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
        public int estado;
        public CustomMessageBox(String contenido, String titulo, int nLineas)
        {
            InitializeComponent();
            lblContenido.Text = contenido;
            lblTitulo.Text = titulo;
            this.StartPosition = FormStartPosition.CenterScreen;
            setDimension(nLineas);
            if(titulo == "Mensaje de confirmación")
            {
                btnAceptar.Location = new Point(245, 40);
                btnNo.Location = new Point(355, 40);
                btnNo.Visible = true;
            }else{
                btnAceptar.Location = new Point(300, 40);
                btnNo.Visible = false;
            }
        }
        public int getEstado()
        {
            return estado;
        }
        public void setDimension(int numLineas)
        {
            Size = new Size(700, (100+(numLineas-1)*13));
            panelContenedor.Size = new Size(700, (70 + (numLineas - 1) * 13));
            btnAceptar.Location = new Point(btnAceptar.Location.X, (40 + (numLineas - 1) * 13));
            btnNo.Location = new Point(btnNo.Location.X, (40 + (numLineas - 1) * 13));
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            estado = 1;
            this.Dispose();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            estado = 0;
            this.Dispose();
        }
    }
}
