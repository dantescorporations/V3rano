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
    public partial class frmGastos : Form
    {
        public frmGastos()
        {
            InitializeComponent();
        }
        bool btnInsertarPresionado = false;
        bool btnModificarPresionado = false;
        bool btnEliminarPresionado = false;
        string straux;

        public void Habilitar()
        {

            txtImporte.Enabled = true;
            cboEmpleado.Enabled = true;
            cboTipoGasto.Enabled = true;
          

        }
        public void Deshabilitar()
        {
            txtImporte.Enabled = false;
            cboEmpleado.Enabled = false;
            cboTipoGasto.Enabled = false;
           
        }

        public void Limpiar()
        {
            txtImporte.Text = "";
            cboEmpleado.Text = "";
            cboTipoGasto.Text = "";
        }

        private void frmGastos_Load(object sender, EventArgs e)
        {
            Deshabilitar();
            try
            {
                string query = "SELECT idTipoGasto,descripcion FROM tipogasto WHERE estatus=1";
                string query2 = " SELECT idEmpleado,nombre FROM empleado WHERE estatus= 1";
              
                Conexion.LlenarComboBox(cboTipoGasto, query);
                Conexion.LlenarComboBox(cboEmpleado, query2);
               

            }
            catch (Exception)
            {

                //throw;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnBuscarPlan_Click(object sender, EventArgs e)
        {
            try
            {
                frmBuscar frm = new frmBuscar();
                frm.Consulta = "SELECT * FROM vista_gasto";
                frm.ShowDialog();
                straux = frm.ID;
                if (straux.Trim() == "")
                    return;

                DataRow dr = Conexion.ObtenerDatos("SELECT * FROM gasto where idGasto = '" + straux + "'");



                txtImporte.Text = dr.ItemArray[1].ToString();
                cboEmpleado.SelectedValue = dr.ItemArray[3].ToString();
                cboTipoGasto.SelectedValue = dr.ItemArray[4].ToString();
            }
            catch (Exception)
            {

                return;
            }

      
         
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
            if (Conexion.ValidarRegistro("SELECT * FROM gasto WHERE estatus = 1"))
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

                    linea = "INSERT INTO gasto(monto,estatus, idEmpleado, idTipoGasto) VALUES ('" + txtImporte.Text + "',1, '" + cboEmpleado.SelectedValue + "', '" + cboTipoGasto.SelectedValue + "')";
                    Conexion.RegistrarLog("Inserto importe " );
                    Conexion.Insertar(linea);
                }
                if (btnModificarPresionado)
                {
                    string linea;

                    linea = "UPDATE gasto SET monto='" + txtImporte.Text + "', estatus='1', idEmpleado='" + cboEmpleado.SelectedValue + "', idTipoGasto='" + cboTipoGasto.SelectedValue + "' WHERE idGasto= " + straux;
                    Conexion.RegistrarLog("Modifico importe ");
                    Conexion.Insertar(linea);
                }
                if (btnEliminarPresionado)
                {
                    string linea;

                    linea = "UPDATE gasto SET  estatus= 0 WHERE idGasto= " + straux;
                    Conexion.RegistrarLog("Elimino importe ");
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Conexion.ValidarRegistro("SELECT * FROM gasto WHERE estatus = 1"))
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
