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
    public partial class frmRecepcionDeCotizacion : Form
    {
        DataRow dr1, dr2;
        string straux, straux2;
        string empleado;
        string linea;

        public frmRecepcionDeCotizacion()
        {
            InitializeComponent();
            l();
        }

        private void l()
        {

            lstCotizacion.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lstCotizacion.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void frmRecepcionDeCotizacion_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM cotizacion";
            Conexion.LlenarListView(lstCotizacion, query);
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


                txtProducto.Text = "" + dr1.ItemArray[1].ToString();  
                txtPrecio.Text="" + dr1.ItemArray[2].ToString();


            }
            catch (Exception)
            {

                return;
            }

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

                txtCliente.Text = "" + dr2.ItemArray[1].ToString();
            }
            catch (Exception)
            {

                return;
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            empleado = Conexion.SUsuario;

            linea = "INSERT INTO cotizacion (numeroCot, descripcion, estatus, idEmpleado, idCliente, idProducto, fecha, cantidad, precio) VALUES (" + Convert.ToInt32(txtN.Text) + ",'" + txtDesc.Text + "',1," + Convert.ToInt32(empleado) + "," + Convert.ToInt32(dr2.ItemArray[0].ToString()) + "," + Convert.ToInt32(dr1.ItemArray[0].ToString()) + ",'" + mskFecha.Text + "'," + Convert.ToInt32(txtCantidad.Text) + ",'" + Convert.ToDecimal(txtPrecio.Text)+ "')";
            Conexion.RegistrarLog(linea);
            Conexion.Insertar(linea);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

        }


    }
}
