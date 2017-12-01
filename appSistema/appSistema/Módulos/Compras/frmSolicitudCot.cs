using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace appSistema
{
    public partial class frmSolicitudCot : Form
    {
        public frmSolicitudCot()
        {
            InitializeComponent();
            l();
        }
        private void l()
        {

            lstvCotizacion.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lstvCotizacion.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void SolicitudCot_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ToExcel()
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel File|*.xlsx", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                    Workbook wb = app.Workbooks.Add(XlSheetType.xlWorksheet);
                    Worksheet ws = (Worksheet)app.ActiveSheet;
                    app.Visible = false;
                    int i = 1;
                    int j = 1;
                    if (!(lstvCotizacion.SelectedItems.Count <= 0))
                    {
                        foreach (ListViewItem lvi in lstvCotizacion.SelectedItems)
                        {
                            i = 1;
                            foreach (ListViewItem.ListViewSubItem lvs in lvi.SubItems)
                            {
                                ws.Cells[j, i] = lvs.Text;
                                i++;
                            }
                            j++;
                        }
                    }
                    wb.SaveAs(sfd.FileName, XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                    app.Quit();
                    MessageBox.Show("Se guardo correctamente");
                }
            }
        }
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            ToExcel();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscar frm = new frmBuscar();
            frm.Consulta = "SELECT * FROM vista_provedor";
            frm.ShowDialog();
            string straux = frm.ID;
            if (straux.Trim() == "")
                return;

            DataRow dr = Conexion.ObtenerDatos("select * from provedor where idProvedor = '" + straux + "'");


            txtProveedor.Text = dr.ItemArray[1].ToString();

            string query = "SELECT * FROM vista_soliccotizacion WHERE Proveedor = '" + txtProveedor.Text + "'";
            Conexion.Insertar(query);
            Conexion.LlenarListView(lstvCotizacion, query);
            //MessageBox.Show(straux);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Conexion.ExportarExcel_DT()
        }
    }
}
