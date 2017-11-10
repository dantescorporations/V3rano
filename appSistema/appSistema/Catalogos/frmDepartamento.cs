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
    public partial class frmDepartamento : Form
    {
        public frmDepartamento()
        {
            InitializeComponent();
        }
        bool btnInsertarPresionado = false;
        bool btnEliminarPresionado = false;
        bool btnModificarPresionado = false;
        string straux;
        public void Habilitar()
        {
            txtClave.Enabled = true;
            txtNombre.Enabled = true;
            txtExtencion.Enabled = true;
            cboEncargado.Enabled = true;

        }
        public void Deshabilitar()
        {
            txtClave.Enabled = false;
            txtNombre.Enabled = false;
            txtExtencion.Enabled = false;
            cboEncargado.Enabled = false;
        }

        public void Limpiar()
        {
            txtClave.Text = "";
            txtNombre.Text = "";
            txtExtencion.Text = "";
            cboEncargado.Text = "";
        }
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            btnInsertarPresionado = true;
            txtClave.Enabled = true;
            Habilitar();
            gpBAcciones.Visible = true;
            gpBConsultas.Visible = false;
        }

        private void frmDepartamento_Load(object sender, EventArgs e)
        {
            Deshabilitar();
            try
            {
                Deshabilitar();
                string query = "SELECT idEmpleado, nombre FROM empleado WHERE estatus=1";
                Conexion.LlenarComboBox(cboEncargado, query);
   

            }
            catch (Exception)
            {

                return;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (Conexion.ValidarRegistro("SELECT * FROM departamento WHERE estatus = 1"))
            {
                btnModificarPresionado = true;
                Habilitar();
                txtClave.Enabled = false;
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
        public bool Validar()
        {
            return false;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
               

                if (btnInsertarPresionado)
                {
                    if (Validar())
                    {
                        return;
                    }
                    string linea;

                    linea = "INSERT INTO departamento(clave, estatus, nombre, extencion, encargado)VALUES('" + txtClave.Text + "', 1, '" + txtNombre.Text + "', '" + txtExtencion.Text + "', " + cboEncargado.SelectedValue + ")";
                    Conexion.RegistrarLog("Inserto departamento " + txtClave.Text);
                    Conexion.Insertar(linea);
                }
                if (btnModificarPresionado)
                {
                    string linea;

                    linea = "UPDATE departamento SET clave='" + txtClave.Text + "', nombre='" + txtNombre.Text + "', extencion='" + txtExtencion.Text + "', encargado=" + cboEncargado.SelectedValue + " WHERE idDepartamento=" + straux;
                    Conexion.RegistrarLog("Modifico departamento " + txtClave.Text);
                    Conexion.Insertar(linea);
                }
                if (btnEliminarPresionado)
                {
                    string linea;

                    linea = "UPDATE departamento SET  estatus= 0 WHERE idDepartamento= " + straux;
                    Conexion.RegistrarLog("Elimino departamento " + txtClave.Text);
                    Conexion.Insertar(linea);
                    Limpiar();
                }
                BtnCancelar_Click(sender, e);
            
           
           
        }

        private void btnBuscarPlan_Click(object sender, EventArgs e)
        {
            try
            {
                frmBuscar frm = new frmBuscar();
                frm.Consulta = "SELECT * FROM vista_departamento";
                frm.ShowDialog();
                straux = frm.ID;
                if (straux.Trim() == "")
                    return;

                DataRow dr = Conexion.ObtenerDatos("SELECT * FROM departamento where idDepartamento = '" + straux + "'");

                txtClave.Text = dr.ItemArray[1].ToString();
                txtNombre.Text = dr.ItemArray[3].ToString();
                txtExtencion.Text = dr.ItemArray[4].ToString();
                cboEncargado.SelectedValue = dr.ItemArray[5].ToString();
         
            }
            catch (Exception)
            {

                return;
            }
          
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Conexion.ValidarRegistro("SELECT * FROM departamento WHERE estatus = 1"))
            {
                btnEliminarPresionado = true;

                txtClave.Enabled = false;
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

        private void cboEncargado_SelectedIndexChanged(object sender, EventArgs e)
        {

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
