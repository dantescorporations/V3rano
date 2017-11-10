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
    public partial class frmFlijosDeEfectivo : Form
    {
        public frmFlijosDeEfectivo()
        {
            InitializeComponent();
        }

        private void frmFlijosDeEfectivo_Load(object sender, EventArgs e)
        {

            lstIngresos.Clear();
            lstIngresos.Refresh();

            //ColumnHeader h1, h2, h3;
            //h1 = new ColumnHeader();
            //h2 = new ColumnHeader();
            //h3 = new ColumnHeader();
            //h1.Text = "Mes";
            //h1.Width = 100;
            //h2.Text = "Venta";
            //h2.Width = 90;
            //h3.Text = "TOTAL";
            //h3.Width = 90;
            //lstIngresos.Columns.Add(h1);
            //lstIngresos.Columns.Add(h2);
            //lstIngresos.Columns.Add(h3);


            string query = "SELECT * FROM vista_ingresos ";
            Conexion.LlenarListView(lstIngresos, query);


            lstEgresos.Clear();
            lstEgresos.Refresh();
            string query2 = "SELECT * FROM vista_egresos ";
            Conexion.LlenarListView(lstEgresos, query2);
        }
    }
}
