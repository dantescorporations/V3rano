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
    public partial class frmBancos : Form
    {
        public frmBancos()
        {
            InitializeComponent();
        }

        private void frmBancos_Load(object sender, EventArgs e)
        {

            string query1 = "CALL proc_Bancos() ";

            lstEntradas.Clear();
            lstEntradas.Refresh();

            ColumnHeader h1, h2, h3, h4, h5, h6;
            h1 = new ColumnHeader();
            h2 = new ColumnHeader();
            h3 = new ColumnHeader();
            h4 = new ColumnHeader();
            h5 = new ColumnHeader();
            h6 = new ColumnHeader();

            h1.Text = "Fecha";
            h1.Width = 120;
            h2.Text = "Concepto";
            h2.Width = 120;
            h3.Text = "Tipo";
            h3.Width = 120;
            h4.Text = "Entrada";
            h4.Width = 120;
            h5.Text = "Salida";
            h5.Width = 120;
            h6.Text = "Saldo";
            h6.Width = 120;

            lstEntradas.Columns.Add(h1);
            lstEntradas.Columns.Add(h2);
            lstEntradas.Columns.Add(h3);
            lstEntradas.Columns.Add(h4);
            lstEntradas.Columns.Add(h5);
            lstEntradas.Columns.Add(h6);

            Conexion.LlenarListView(lstEntradas, query1);
            //decimal t=0;

            string query2 = "CALL proc_TotalEntrada()";
            Conexion.LlenarListView(lstE, query2);

            string query3 = "CALL proc_TotalSalida()";
            Conexion.LlenarListView(lstS, query3);

            //if (dr != null)
            //{
            //lblActual.Text = "" + t;
            //}
        }
    }
}
