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
    public partial class frmDevolucionSobreVenta : Form
    {
        string straux;
        string straux2;
        string chk;
        string empleado;

        DataRow dr1, dr2;
        public frmDevolucionSobreVenta()
        {
            InitializeComponent();
        }

        private void btnBuscarFac_Click(object sender, EventArgs e)
        {
            try
            {
                frmBuscar frm = new frmBuscar();
                frm.Consulta = "SELECT * FROM vista_facturaventa";
                frm.ShowDialog();
                straux = frm.ID;
                if (straux.Trim() == "")
                    return;

                dr1 = Conexion.ObtenerDatos("SELECT * FROM facturaventa where idFacturaVenta= '" + straux + "'");



                lblDatosFactura.Text = "Folio: " + dr1.ItemArray[7].ToString() + "\n" +
               "Cliente: " + dr1.ItemArray[3].ToString() + "\n" +
               "Fecha: " + dr1.ItemArray[5].ToString();
            }
            catch (Exception)
            {

                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
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

            empleado = Conexion.SUsuario; 
            string linea;

            linea = "INSERT INTO devolucionventa (descripcion, estatus,idEmpleado,idFacturaVenta) VALUES ('" + chk + "',1,'" + empleado + "'," + Convert.ToInt32(dr1.ItemArray[0].ToString()) + ")";
            Conexion.RegistrarLog(linea);
            Conexion.Insertar(linea);
        }
        }
    }
