using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSistema.Módulos
{
    public partial class frmPrefacturacion : Form
    {
        public frmPrefacturacion()
        {
            InitializeComponent();
            l();
        }
        private void l()
        {

            lstvProducto.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lstvProducto.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            
        }
        private void frmPrefacturacion_Load(object sender, EventArgs e)
        {

        }
       
        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            lstvProducto.Columns.Clear();
            lstvProducto.Items.Clear();
            label1.Text = "";
            string query = "SELECT * FROM vista_producto";

            Conexion.LlenarListView(lstvProducto, query);

            DataRow dr = Conexion.ObtenerDatos(query);

            Double Suma = 0;

            foreach (ListViewItem item in lstvProducto.Items)
            {
                Suma += Convert.ToDouble(item.SubItems[3].Text);
            }
            label1.Text = "Total: $"+Suma.ToString();

           l();
           
           
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            lstvProducto.Columns.Clear();
            lstvProducto.Items.Clear();
            label1.Text = "";
            string query = "SELECT * FROM vista_cliente";
            Conexion.LlenarListView(lstvProducto, query);
           
            l();
        }
    }
}
