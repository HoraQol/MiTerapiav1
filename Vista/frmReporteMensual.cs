using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using Controlador;

namespace Vista
{
    public partial class frmReporteMensual : Form
    {
        private BindingList<Terapeuta> listTerap;
        public frmReporteMensual()
        {
            InitializeComponent();
            llenarMes();
            llenarTerap();
        }
        public String obtenerClaveMes(int mes, int anho)
        {
            switch (mes)
            {
                case 1:
                    return "Enero " + anho.ToString();
                case 2:
                    return "Febrero " + anho.ToString();
                case 3:
                    return "Marzo " + anho.ToString();
                case 4:
                    return "Abril " + anho.ToString();
                case 5:
                    return "Mayo " + anho.ToString();
                case 6:
                    return "Junio " + anho.ToString();
                case 7:
                    return "Julio " + anho.ToString();
                case 8:
                    return "Agosto " + anho.ToString();
                case 9:
                    return "Septiembre " + anho.ToString();
                case 10:
                    return "Octubre " + anho.ToString();
                case 11:
                    return "Noviembre " + anho.ToString();
                default:
                    return "Diciembre " + anho.ToString();
            }
        }
        public void llenarMes()
        {
            int mes = DateTime.Now.Month, anho = DateTime.Now.Year;
            cboMes.Items.Add(obtenerClaveMes(mes, anho));
            for (int i = 0; i < 5; i++)
            {
                if (mes == 12)
                {
                    mes = 1;
                    anho++;
                }
                else mes++;
                cboMes.Items.Add(obtenerClaveMes(mes, anho));
            }
        }
        public void llenarTerap()
        {
            TerapeutaBL controlTerap = new TerapeutaBL();
            listTerap = controlTerap.obtenerLista();
            for (int i = 0; i < listTerap.Count; i++)
            {
                cboTerap.Items.Add(listTerap[i].ApPat.ToUpper() + " " + listTerap[i].ApMat.
                    ToUpper() + ", " + listTerap[i].Nombre);
            }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                MessageBox.Show("Path found: " + fbd.SelectedPath.ToString(), "Message");
            }
        }

        private void cboMes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
