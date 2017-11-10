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
    public partial class frmObligaciones : Form
    {
        public frmObligaciones()
        {
            InitializeComponent();
        }
        bool btnInsertarPresionado = false;
        bool btnModificarPresionado = false;
        bool btnEliminarPresionado = false;
        string straux;
        public void Habilitar()
        {

            txtDescripcion.Enabled = true;
            cboEmpleado.Enabled = true;
            cboTipoObligacion.Enabled = true;

        }
        public void Deshabilitar()
        {
          
            txtDescripcion.Enabled = false;
            cboEmpleado.Enabled = false;
            cboTipoObligacion.Enabled = false;
        }

        public void Limpiar()
        {
            txtDescripcion.Text = "";
            cboEmpleado.Text = "";
            cboTipoObligacion.Text = "";
        }
        public bool Validar()
        {
            return false;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {


                if (btnInsertarPresionado)
                {
                    if (Validar())
                    {
                        return;
                    }
                    string linea;

                    linea = "INSERT INTO obligacion(descripcion,estatus, idTipoObligacion, idEmpleado) VALUES ('" + txtDescripcion.Text + "', 1,'" + cboTipoObligacion.SelectedValue + "', '" + cboEmpleado.SelectedValue + "')";
                    Conexion.RegistrarLog("Inserto obligacion "+txtDescripcion.Text);
                    Conexion.Insertar(linea);
                }
                if (btnModificarPresionado)
                {
                    string linea;

                    linea = "UPDATE obligacion SET descripcion='" + txtDescripcion.Text + "', estatus='1', idTipoObligacion='" + cboTipoObligacion.SelectedValue + "', idEmpleado='" + cboEmpleado.SelectedValue + "' WHERE idObligacion=" + straux;
                    Conexion.RegistrarLog("Modifico obligacion " + txtDescripcion.Text);
                    Conexion.Insertar(linea);
                }
                if (btnEliminarPresionado)
                {

                    string linea;

                    linea = "UPDATE obligacion SET  estatus= 0 WHERE idObligacion= " + straux;
                    Conexion.RegistrarLog("Elimino obligacion " + txtDescripcion.Text);
                    Conexion.Insertar(linea);
                    Limpiar();
                }
                BtnCancelar_Click(sender, e);
            }
            catch (Exception)
            {

                return;
            }
           
         
        }

        private void frmObligaciones_Load(object sender, EventArgs e)
        {

            Deshabilitar();
            string query = "SELECT idTipoObligacion,descripcion FROM tipoobligacion WHERE estatus= 1";
            Conexion.LlenarComboBox(cboTipoObligacion, query);

            string query2 = "SELECT idEmpleado,nombre FROM empleado WHERE estatus= 1";
            Conexion.LlenarComboBox(cboEmpleado, query2);
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            btnInsertarPresionado = true;
   
            Habilitar();
            gpBAcciones.Visible = true;
            gpBConsultas.Visible = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (Conexion.ValidarRegistro("SELECT * FROM obligacion WHERE estatus = 1"))
            {
                btnModificarPresionado = true;
                Habilitar();

                gpBAcciones.Visible = true;
                gpBConsultas.Visible = false;
                gpBBuscar.Visible = true;
                btnBuscarPlan_Click(sender, e);
            }
            else
            {
                Conexion.MostrarMensaje("No existen Registros");
            }
        }

        private void btnBuscarPlan_Click(object sender, EventArgs e)
        {
            try
            {
                frmBuscar frm = new frmBuscar();
                frm.Consulta = "SELECT * FROM vista_obligacion";
                frm.ShowDialog();
                straux = frm.ID;
                if (straux.Trim() == "")
                    return;

                DataRow dr = Conexion.ObtenerDatos("SELECT * FROM obligacion where idObligacion = '" + straux + "'");



                txtDescripcion.Text = dr.ItemArray[1].ToString();
                cboEmpleado.SelectedValue = dr.ItemArray[4].ToString();
                cboTipoObligacion.SelectedValue = dr.ItemArray[3].ToString();

            }
            catch (Exception)
            {

                return;
            }
            
           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Conexion.ValidarRegistro("SELECT * FROM obligacion WHERE estatus = 1"))
            {
                btnEliminarPresionado = true;


                gpBAcciones.Visible = true;
                gpBConsultas.Visible = false;
                gpBBuscar.Visible = true;
                btnBuscarPlan_Click(sender, e);
            }
            else
            {
                Conexion.MostrarMensaje("No existen Registros");
            }

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            gpBAcciones.Visible = false;
            gpBBuscar.Visible = false;
            gpBConsultas.Visible = true;
            Limpiar();
            Deshabilitar();


            btnInsertarPresionado = false;
            btnModificarPresionado = false;
            btnEliminarPresionado = false;
        }
    }
}
