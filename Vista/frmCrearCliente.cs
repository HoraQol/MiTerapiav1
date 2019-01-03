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
using Vista.Auxiliar;

namespace Vista
{
    public partial class frmCrearCliente : Form
    {
        public frmCrearCliente()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            cboTipoDoc.SelectedIndex = 0;
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

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private BindingList<String> validarDatos()
        {
            BindingList<String> errores = new BindingList<String>();
            // DNI
            if (((txtDoc.Text.Length != 8) && (cboTipoDoc.SelectedIndex == 0)) ||
                    ((txtDoc.Text.Length != 12) && (cboTipoDoc.SelectedIndex == 1)))
                errores.Add("El número de documento de identidad no corresponde al formato " +
                    "especificado.\n");
            // Vacíos
            if (txtDoc.Text == "")
                errores.Add("No se ha ingresado número de documento de identidad.\n");
            if(txtApPat.Text == "")
                errores.Add("No se ha ingresado apellido paterno.\n");
            if (txtApMat.Text == "")
                errores.Add("No se ha ingresado apellido materno.\n");
            if (txtNombres.Text == "")
                errores.Add("No se ha ingresado nombre(s).\n");
            if (txtTelef.Text == "")
                errores.Add("No se ha ingresado teléfono.\n");
            return errores;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            BindingList<String> errores = validarDatos();
            if (errores.Count == 0)
            {
                Cliente cli = new Cliente(1, txtNombres.Text, txtApPat.Text, txtApMat.Text,
                    cboTipoDoc.SelectedIndex + 1, Int32.Parse(txtDoc.Text), dtpFechNac.Value,
                    cboCateg.SelectedIndex + 1, txtTelef.Text, 1);
                ClienteBL controlCli = new ClienteBL();
                if (!controlCli.registrarCliente(cli))
                {
                    CustomMessageBox frm = new CustomMessageBox("Ha ocurrido un error interno. " +
                        "Por favor, contacte a algún administrador", "Mensaje de error", 1);
                    frm.ShowDialog();
                }
                else
                {
                    CustomMessageBox frm = new CustomMessageBox("El cliente ha sido registrado " +
                        "correctamente.", "Registro correcto", 1);
                    frm.ShowDialog();
                }
                this.Dispose();
            }
            else
            {
                string mensaje = "Se ha encontrado " + ((errores.Count == 1) ? 
                    "el siguiente error:\n\n": "los siguientes errores:\n\n");
                for(int i=0; i<errores.Count; i++)
                {
                    mensaje += "(" + (i+1).ToString() + ") " + errores[i];
                }
                CustomMessageBox frm = new CustomMessageBox(mensaje+"\nPor favor, verifique " +
                    "dichas observaciones antes de finalizar el registro.",
                    "Mensaje de advertencia",errores.Count+4);
                frm.ShowDialog();
            }
        }

        private void txtDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            new KeyPressControl().digit(sender, e);
        }

        private void txtApPat_KeyPress(object sender, KeyPressEventArgs e)
        {
            new KeyPressControl().letter(sender, e);
        }

        private void txtApMat_KeyPress(object sender, KeyPressEventArgs e)
        {
            new KeyPressControl().letter(sender, e);
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            new KeyPressControl().letter(sender, e);
        }

        private void txtTelef_KeyPress(object sender, KeyPressEventArgs e)
        {
            new KeyPressControl().phone(sender, e);
        }
    }
}
