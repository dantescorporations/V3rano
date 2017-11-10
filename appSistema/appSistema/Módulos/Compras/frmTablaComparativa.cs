using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSistema
{
    public partial class frmTablaComparativa : Form
    {
        public frmTablaComparativa()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmTablaComparativa_Load(object sender, EventArgs e)
        {
            mostrar();
        }
        private void l()
        {

            lstTblacomparativa.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lstTblacomparativa.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }
        public void mostrar()
        {

            lstTblacomparativa.Columns.Clear();
            lstTblacomparativa.Items.Clear();
            string query = "select * from Vista_tablacomparativa";
            Conexion.LlenarListView(lstTblacomparativa, query);
            DataRow dr = Conexion.ObtenerDatos(query);


            Conexion.LlenarComboBox(cboProveedor, "SELECT idContactoP,nombre FROM contactoproveedor WHERE estatus=1");


            l();
        }

        private void lstTblacomparativa_DoubleClick(object sender, EventArgs e)
        {
           
            string nombre = lstTblacomparativa.SelectedItems[0].SubItems[0].Text;
            string precio= lstTblacomparativa.SelectedItems[0].SubItems[1].Text;
            string codigo= lstTblacomparativa.SelectedItems[0].SubItems[2].Text;
                string nemp=lstTblacomparativa.SelectedItems[0].SubItems[3].Text;
                    string telemp=lstTblacomparativa.SelectedItems[0].SubItems[4].Text;
                        string nompov=lstTblacomparativa.SelectedItems[0].SubItems[5].Text;
                            string ap=lstTblacomparativa.SelectedItems[0].SubItems[6].Text;
                                string am=lstTblacomparativa.SelectedItems[0].SubItems[7].Text;
                                string telprov = lstTblacomparativa.SelectedItems[0].SubItems[8].Text;

                                string aprovar = "Producto: " + nombre + "," + " Precio: " + precio + "," + "Codigo: " + codigo + "," + " Nombre empresa: " + nemp + "," + " Num empresa: "+ telemp +  ", "+" Nombre Proveedor: " + nompov + "  " + ap + "  " + am + "," + " Tel proveedor: " + telprov;
        
            lstAprobados.Items.Add(aprovar);

         
        }

        private void cboProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            lstTblacomparativa.Columns.Clear();
            lstTblacomparativa.Items.Clear();
            string query = "SELECT * FROM Vista_tablacomparativa WHERE Nombre_proveeedor= '" + cboProveedor.Text + "'";
            Conexion.LlenarListView(lstTblacomparativa, query);
            DataRow dr = Conexion.ObtenerDatos(query);
            l();
        }

        private void btnBuscartodos_Click(object sender, EventArgs e)
        {
            mostrar();
        }

        private void btnEliminarAprobados_Click(object sender, EventArgs e)
        {

            foreach (ListViewItem item in lstAprobados.SelectedItems)
                lstAprobados.Items.Remove(item);
        }

      
    }
}
