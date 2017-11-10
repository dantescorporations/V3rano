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
    public partial class frmRequisicion : Form
    {
        public frmRequisicion()
        {
            InitializeComponent();
        }
        bool btnInsertarPresionado = false;
        bool btnModificarPresionado = false;
        string straux;

        public void Habilitar()
        {
            txtNumero.Enabled = true;
            txtCantidad.Enabled = true;
            mskFechaP.Enabled = true;
            mskFechaE.Enabled = true;
            cboEmpleado.Enabled = true;
            cboProducto.Enabled = true;
            cboUnidad.Enabled = true;
        }
        public void Deshabilitar()
        {
            txtNumero.Enabled = false;
            txtCantidad.Enabled = false;
            mskFechaP.Enabled = false;
            mskFechaE.Enabled = false;
            cboEmpleado.Enabled = false;
            cboProducto.Enabled = false;
            cboUnidad.Enabled = false;
        }

        public void Limpiar()
        {
            txtNumero.Text = "";
            txtCantidad.Text = "";
            mskFechaP.Text = "";
            mskFechaE.Text = "";
            cboEmpleado.Text = "";
            cboProducto.Text = "";
            cboUnidad.Text = "";
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            btnInsertarPresionado = true;
            txtNumero.Enabled = true;
            Habilitar();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            btnModificarPresionado = true;
            Habilitar();
            txtNumero.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            Deshabilitar();
            if (btnInsertarPresionado)
            {
                string linea;

                linea = "INSERT INTO requisicion(NoRequisicion, idProducto, idUnidad, idEmpleado, cantidad, fechaPedido, fechaEntrega, estatus) VALUES ('" + txtNumero.Text + "', '" + cboProducto.SelectedValue + "','" + cboUnidad.SelectedValue + "', '" + cboEmpleado.SelectedValue + "','" + txtCantidad.Text + "', '" + mskFechaP.Text + "', '" + mskFechaE.Text + "','0')";
                Conexion.RegistrarLog(linea);
                Conexion.Insertar(linea);
            }
            if (btnModificarPresionado)
            {
                string linea;

                linea = "UPDATE requisicion SET idProducto ='" + cboProducto.ValueMember + "', cantidad='" + txtCantidad.Text + "', idUnidad='" + cboUnidad.ValueMember + "', fechaPedido='" + mskFechaP.Text + "', fechaEntrega='" + mskFechaE.Text + "', idEmpleado='" + cboEmpleado.ValueMember + "' WHERE NoRequisicion= " + straux;
                Conexion.RegistrarLog(linea);
                Conexion.Modificar(linea);
            }
            btnInsertarPresionado = false;
            btnModificarPresionado = false;
            Limpiar();
        }

        private void frmRequisicion_Load(object sender, EventArgs e)
        {
            Deshabilitar();
            try
            {
                string query = "SELECT idProducto, nombre FROM producto WHERE estatus=1";
                string query2 = "SELECT idUnidadMedida, descripcion FROM unidadmedida WHERE estatus=1";
                string query3 = "SELECT Id, NombreCompleto FROM vista_empleado";

                Conexion.LlenarComboBox(cboProducto, query);
                Conexion.LlenarComboBox(cboUnidad, query2);
                Conexion.LlenarComboBox(cboEmpleado, query3);


            }
            catch (Exception)
            {

                return;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                frmBuscar frm = new frmBuscar();
                frm.Consulta = "SELECT * FROM vista_requisicion";
                frm.ShowDialog();
                straux = frm.ID;
                if (straux.Trim() == "")
                    return;

                DataRow dr = Conexion.ObtenerDatos("select * from requisicion where NoRequisicion= '" + straux + "'");

                txtNumero.Text = dr.ItemArray[1].ToString();
                cboProducto.ValueMember = dr.ItemArray[2].ToString();
                cboUnidad.ValueMember = dr.ItemArray[3].ToString();
                cboEmpleado.ValueMember = dr.ItemArray[4].ToString();
                txtCantidad.Text = dr.ItemArray[5].ToString();
                mskFechaP.Text = dr.ItemArray[6].ToString();
                mskFechaE.Text = dr.ItemArray[7].ToString();
            }
            catch (Exception)
            {

                return;
            }
        }
    }
}
