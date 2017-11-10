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
    public partial class frmDevolucionSobreCompra : Form
    {
        string straux;
        string straux2;
        string chk;


        DataRow dr1, dr2;
        public frmDevolucionSobreCompra()
        {
            InitializeComponent();
        }

        private void frmDevolucionSobreCompra_Load(object sender, EventArgs e)
        {

        }

        private void btnFact_Click(object sender, EventArgs e)
        {
            try
            {
                frmBuscar frm = new frmBuscar();
                frm.Consulta = "SELECT * FROM vista_facturacompra";
                frm.ShowDialog();
                straux = frm.ID;
                if (straux.Trim() == "")
                    return;

                dr1 = Conexion.ObtenerDatos("SELECT * FROM facturacompra where idFacturaCompra= '" + straux + "'");



                lblDatosFactura.Text = "Folio: " + dr1.ItemArray[1].ToString() + "\n" +
                "Proveedor: " + dr1.ItemArray[6].ToString() + "\n" +
                "Fecha: " + dr1.ItemArray[4].ToString();
            }
            catch (Exception)
            {

                return;
            }
        }

        private void btnProd_Click(object sender, EventArgs e)
        {
            try
            {
                frmBuscar frm = new frmBuscar();
                frm.Consulta = "SELECT * FROM vista_producto";
                frm.ShowDialog();
                straux2 = frm.ID;
                if (straux.Trim() == "")
                    return;

                dr2 = Conexion.ObtenerDatos("SELECT * FROM producto where idProducto = '" + straux2 + "'");


                lblDatosProducto.Text = "Código: " + dr2.ItemArray[3].ToString() + "\n" +
                "Nombre: " + dr2.ItemArray[1].ToString() + "\n" +
                "Precio: " + dr2.ItemArray[2].ToString();


            }
            catch (Exception)
            {

                return;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (chkArticuloDañado.Checked && !chkAtriculoNS.Checked)
            {
                chk = "Articulo Dañado";
            }
            else if (!chkArticuloDañado.Checked && chkAtriculoNS.Checked)
            {
                chk = "Articulo No Solicitado";
            }

            string linea;

            linea = "INSERT INTO devolucioncompra (estatus, descripcion,idProveedor,idFacturaCompra, idProducto) VALUES (1,'" + chk + "'," + Convert.ToInt32(dr1.ItemArray[6].ToString()) + "," + Convert.ToInt32(dr1.ItemArray[0].ToString()) + "," + Convert.ToInt32(dr2.ItemArray[0].ToString()) + ")";
            Conexion.RegistrarLog(linea);
            Conexion.Insertar(linea);
        }
    }
}
