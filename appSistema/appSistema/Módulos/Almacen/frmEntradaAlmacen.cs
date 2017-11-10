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
    public partial class frmEntradaAlmacen : Form
    {
        string idAlmacen;
        string idOrdenC;
        public frmEntradaAlmacen()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void frmEntradaAlmacen_Load(object sender, EventArgs e)
        {
            btnEnlazar.Visible = false;
            btnHecho.Visible = false;
            ltvfacturas.Visible = false;
        }
        private void Llenar()
        {
            // falta idOrdenCompra
            string query = "SELECT * FROM vista_validarfactura WHERE idOrdenCompra=" + idOrdenC;
            Conexion.LlenarListView(ltvEntrada, query);
        }

        private void btnEnlazar_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarOC_Click(object sender, EventArgs e)
        {
            try
            {
                frmBuscar frm = new frmBuscar();
                frm.Consulta = "SELECT * FROM vista_ordencompra";
                frm.ShowDialog();
                idOrdenC = frm.ID;
                if (idOrdenC.Trim() == "")
                    return;

                DataRow dr = Conexion.ObtenerDatos("SELECT * FROM ordencompra where idOrdenCompra='" + idOrdenC + "'");

                //  lblOrden.Text = "No. Orden de Compra: " + dr.ItemArray[1].ToString();
                // vista no tiene id Orden de compra
               // lblOC.Text = dr.ItemArray[1];
                Llenar();

            }
            catch (Exception)
            {

                //Log
            }
            
        }

        private void btnEnlazar_Click_1(object sender, EventArgs e)
        {

        }

        private void btnHecho_Click(object sender, EventArgs e)
        {

        }
    }
}
