using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSistema.Catalogos
{
    public partial class frmTipoContactoProveedor : Form
    {
        public frmTipoContactoProveedor()
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
        }
        public void Deshabilitar()
        {

            txtDescripcion.Enabled = false;
        }

        public void Limpiar()
        {
            txtDescripcion.Text = "";
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

                    linea = "INSERT INTO tipocontactoproveedor(estatus,descripcion) VALUES (1,'" + txtDescripcion.Text + "')";
                    Conexion.RegistrarLog("Inserto tipo contacto proveedor " + txtDescripcion.Text);
                    Conexion.Insertar(linea);

                }
                if (btnModificarPresionado)
                {
                    string linea;
                    DialogResult dialogresult = MessageBox.Show("Esta seguro de realizar los cambios", "Mensaje", MessageBoxButtons.YesNo);
                    if (dialogresult == DialogResult.Yes)
                    {
                        linea = " UPDATE tipocontactoproveedor SET estatus=1,descripcion=  '" + txtDescripcion.Text + "' WHERE idTipoContactoProveedor=" + straux;
                        Conexion.RegistrarLog("Modifico tipo contacto proveedor " + txtDescripcion.Text);
                        Conexion.Insertar(linea);
                    }
                    else
                    {
                        return;
                    }
                }
                if (btnEliminarPresionado)
                {
                    if (Conexion.ValidarEstatus("SELECT * FROM contactoproveedor WHERE estatus=1 and idTipoContactoProveedor=" + straux))
                    {

                        MessageBox.Show("El Registro no puede ser Eliminado por que esta siendo usado en otros campos");
                        return;
                    }
                    string linea;
                    DialogResult dialogresult = MessageBox.Show("Realmente desea guardar los cambios", "Mensaje", MessageBoxButtons.YesNo);
                    if (dialogresult == DialogResult.Yes)
                    {
                        linea = "UPDATE tipocontactoproveedor SET  estatus= 0 WHERE idTipoContactoProveedor= " + straux;
                        Conexion.RegistrarLog("Elimino tipo contacto proveedor " + txtDescripcion.Text);
                        Conexion.Insertar(linea);
                        Limpiar();

                    }
                    else
                    {
                        return;
                    }
                }
                BtnCancelar_Click(sender, e);



            }
            catch (Exception)
            {

                return;
            }
          
           
        }

        private void frmTipoContactoProveedor_Load(object sender, EventArgs e)
        {
            Deshabilitar();
        }

        private void btnBuscarPlan_Click(object sender, EventArgs e)
        {
            try
            {
                frmBuscar frm = new frmBuscar();
                frm.Consulta = "SELECT * FROM vista_tipocontactoproveedor";
                frm.ShowDialog();
                straux = frm.ID;
                if (straux.Trim() == "")
                    return;

                DataRow dr = Conexion.ObtenerDatos("SELECT * FROM tipocontactoproveedor where idTipoContactoProveedor = '" + straux + "'");

                txtDescripcion.Text = dr.ItemArray[2].ToString();
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
            if (Conexion.ValidarRegistro("SELECT * FROM tipocontactoproveedor WHERE estatus = 1"))
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Conexion.ValidarRegistro("SELECT * FROM tipocontactoproveedor WHERE estatus = 1"))
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
            ////
            
               
         
         
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
