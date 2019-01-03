using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using Controlador;
using MSExcel = Microsoft.Office.Interop.Excel;

namespace Vista
{
    public partial class frmReporteDiario : Form
    {
        private PagoBL adminPago = new PagoBL();
        private BindingList<Pago> listaPago = new BindingList<Pago>();
        private double[] totales = new double[4];
        public frmReporteDiario()
        {
            InitializeComponent();
            dtpFecha.Value = DateTime.Now;
            listaPago = adminPago.obtenerLista(dtpFecha.Value);
            actualizarTabla();
        }
        public void actualizarTabla()
        {
            dgvPagos.Rows.Clear();
            for (int i = 0; i < listaPago.Count; i++)
            {
                if (filtro(listaPago[i]))
                {
                    int rowId = dgvPagos.Rows.Add();
                    DataGridViewRow row = dgvPagos.Rows[rowId];
                    row.Cells["colCli"].Value = "Ejemplo";
                    row.Cells["colMonto"].Value = "88.88";
                    switch (listaPago[i].Tipo)
                    {
                        case 1:
                            row.Cells["colTipo"].Value = "Efectivo";
                            break;
                        case 2:
                            row.Cells["colTipo"].Value = "Pago con tarjeta";
                            break;
                        case 3:
                            row.Cells["colTipo"].Value = "Transferencia";
                            break;
                    }
                    row.Cells["colDoc"].Value = listaPago[i].NumDoc;
                }
            }
            if (listaPago.Count == 1)
                lblIndic.Text = "Se ha encontrado 1 transacción";
            else
                lblIndic.Text = "Se han encontrado " + listaPago.Count().ToString() + 
                    " transacciones";
        }
        public void actualizarTotales()
        {
            for(int i = 0; i < 4; i++)
            {
                totales[i] = 0;
            }
            for (int i = 0; i < listaPago.Count; i++)
            {
                totales[listaPago[i].Tipo - 1] += 88.88;
                totales[3] += 88.88;
            }
            txtEfec.Text = totales[0].ToString("n2");
            txtTarj.Text = totales[1].ToString("n2");
            txtTransf.Text = totales[2].ToString("n2");
            txtTotal.Text = totales[3].ToString("n2");
        }
        public bool filtro(Pago pg)
        {
            if ((pg.Tipo == 1) && chkEfect.Checked)
                return true;
            if ((pg.Tipo == 2) && chkTarj.Checked)
                return true;
            if ((pg.Tipo == 3) && chkTransf.Checked)
                return true;
            return false;
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            listaPago = adminPago.obtenerLista(dtpFecha.Value);
            actualizarTotales();
            actualizarTabla();
        }
        private void chkEfect_CheckedChanged(object sender, EventArgs e)
        {
            actualizarTabla();
        }
        private void chkTarj_CheckedChanged(object sender, EventArgs e)
        {
            actualizarTabla();
        }
        private void chkTransf_CheckedChanged(object sender, EventArgs e)
        {
            actualizarTabla();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                MSExcel.Application hoja = new MSExcel.Application();
                MSExcel.Workbook wb = hoja.Workbooks.Add(MSExcel.XlWBATemplate.xlWBATWorksheet);
                MSExcel.Worksheet ws = wb.ActiveSheet;
                ws.Cells[1, 1] = "Filtros";
                ws.Cells[2, 1] = "Día:";
                ws.Cells[2, 2] = dtpFecha.Value.ToString("dd/MM/yyyy");
                ws.get_Range("A4", "D4").Font.Bold = true;
                ws.get_Range("A4", "D4").VerticalAlignment = MSExcel.XlVAlign.xlVAlignCenter;
                ws.get_Range("A4", "D4").Cells.Borders.LineStyle = MSExcel.XlLineStyle.xlContinuous;
                ws.Columns[1].ColumnWidth = 45;
                ws.Cells[4, 1] = "Cliente";
                ws.Cells[4, 2] = "Monto pagado (S/.)";
                ws.Cells[4, 3] = "Tipo de operación";
                ws.Cells[4, 4] = "Nro. documento";
                wb.SaveAs(fbd.SelectedPath.ToString() +
                    "\\ReporteDiario" + dtpFecha.Value.ToString("yyyyMMdd") + ".xlsx");
            }
        }
    }
}
