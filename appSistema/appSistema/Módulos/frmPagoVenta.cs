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
    public partial class frmPagoVenta : Form
    {
        string straux;
        string straux2, straux3;

        string linea, empleado ;
        string linea2, linea3, linea4;

        DataRow dr1, dr2, dr3;

        public frmPagoVenta()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                frmBuscar frm = new frmBuscar();
                frm.Consulta = "SELECT * FROM vista_producto";
                frm.ShowDialog();
                straux = frm.ID;
                if (straux.Trim() == "")
                    return;

                dr1 = Conexion.ObtenerDatos("SELECT * FROM producto where idProducto = '" + straux + "'");


                lblP.Text = "Código: " + dr1.ItemArray[3].ToString() + "\n" +
                "Nombre: " + dr1.ItemArray[1].ToString() + "\n" +
                "Precio: " + dr1.ItemArray[2].ToString();


            }
            catch (Exception)
            {

                return;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                frmBuscar frm = new frmBuscar();
                frm.Consulta = "SELECT * FROM vista_cliente";
                frm.ShowDialog();
                straux2 = frm.ID;
                if (straux2.Trim() == "")
                    return;

                dr2 = Conexion.ObtenerDatos("SELECT * FROM cliente where idCliente = '" + straux2 + "'");


                lblC.Text = "Cliente: " + dr2.ItemArray[1].ToString() + "\n" +
                "Teléfono: " + dr2.ItemArray[2].ToString() + "\n" +
                "Direccion: " + dr2.ItemArray[3].ToString() + ", #" + dr2.ItemArray[4].ToString() + ", " + dr2.ItemArray[5].ToString() + ", " +
               dr2.ItemArray[6].ToString() + ", " + dr2.ItemArray[7].ToString();


            }
            catch (Exception)
            {

                return;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           
            linea = "INSERT INTO pagoventa (estatus, fecha, monto, tipo) VALUES (1,'" + mskFecha.Text + "','" + Convert.ToDecimal(txtMonto.Text) + "','" +cmbTipo.Text + "')";
            Conexion.Insertar(linea);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            empleado = Conexion.SUsuario;


            linea2 = "INSERT INTO facturaventa (estatus, idCliente, idEmpleado, idOrdenServicio, fecha, tasa, folio, serie) VALUES (1," + Convert.ToInt32(dr2.ItemArray[0].ToString()) + ",'" + empleado + "'," + Convert.ToInt32(dr3.ItemArray[0].ToString()) + ",'" + mskFecha.Text + "','" + Convert.ToDouble(txtTasa.Text) + "','" + txtFolio.Text + "','" + txtSerie.Text + "')";
            Conexion.Insertar(linea2);

            //linea3 = "INSERT INTO detallefacturaventa (idFacturaVenta, estatus, cantidad, descripcion, valorUnitario, idProducto) VALUES (1," + Convert.ToInt32(dr2.ItemArray[0].ToString()) + "," + Convert.ToInt32(empleado) + "'" + mskFecha.Text + "','" + Convert.ToDecimal(txtMonto.Text) + "','" + cmbTipo.Text + "')";
            //Conexion.Insertar(linea);

            //linea = "INSERT INTO pagoventa (estatus, idCliente, idEmpleado, idOrdenServicio, fecha, tasa, folio, serie) VALUES (1," + Convert.ToInt32(dr2.ItemArray[0].ToString()) + "," + Convert.ToInt32(empleado) + "'" + mskFecha.Text + "','" + Convert.ToDecimal(txtMonto.Text) + "','" + cmbTipo.Text + "')";
            //Conexion.Insertar(linea);
           

        }

        private void frmPagoVenta_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmBuscar frm = new frmBuscar();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                frmBuscar frm = new frmBuscar();
                frm.Consulta = "SELECT * FROM vista_cotizacion";
                frm.ShowDialog();
                straux3 = frm.ID;
                if (straux3.Trim() == "")
                    return;

                dr3 = Conexion.ObtenerDatos("SELECT * FROM cotizacion where idCotizacion = '" + straux3 + "'");


                lblCot.Text = "No. Cotización: " + dr3.ItemArray[1].ToString() + "\n" +
                "Fecha: " + dr3.ItemArray[7].ToString();


            }
            catch (Exception)
            {

                return;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
