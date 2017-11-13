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
    public partial class frmAlmacen : Form
    {
        public frmAlmacen()
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
            txtNombre.Enabled = true;
            txtCalle.Enabled = true;
            msktxtNumero.Enabled = true;
            txtColonia.Enabled = true;
            txtColonia.Enabled = true;
            txtCiudad.Enabled = true;
            mskCP.Enabled = true;
          
        }
        public void Deshabilitar()
        {
            txtClave.Enabled = false;
            txtDescripcion.Enabled = false;
            txtNombre.Enabled = false;
            txtCalle.Enabled = false;
            msktxtNumero.Enabled = false;
            txtColonia.Enabled = false;
            txtCiudad.Enabled = false;
            mskCP.Enabled = false;
        }

        public void Limpiar()
        {
            txtClave.Text = "";
            txtDescripcion.Text = "";
            txtNombre.Text = "";
            txtCalle.Text = "";
            msktxtNumero.Text = "";
            txtColonia.Text = "";
            txtCiudad.Text = "";
            mskCP.Text = "";
        }
        private void btnBuscarPlan_Click(object sender, EventArgs e)
        {
            try
            {
                frmBuscar frm = new frmBuscar();
                frm.Consulta = "SELECT * FROM vista_almacen";
                frm.ShowDialog();
                straux = frm.ID;
                if (straux.Trim() == "")
                    return;

                DataRow dr = Conexion.ObtenerDatos("select * from almacen where idAlmacen =  '" + straux + "'");

                txtClave.Text = dr.ItemArray[9].ToString();
                txtDescripcion.Text = dr.ItemArray[2].ToString();
                txtNombre.Text = dr.ItemArray[1].ToString();
                txtCalle.Text = dr.ItemArray[4].ToString();
                msktxtNumero.Text = dr.ItemArray[5].ToString();
                txtColonia.Text = dr.ItemArray[6].ToString();
                txtCiudad.Text = dr.ItemArray[8].ToString();
                mskCP.Text = dr.ItemArray[7].ToString();
            }
            catch (Exception)
            {

                return;
            }
        
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Conexion.ValidarRegistro("SELECT * FROM almacen WHERE estatus = 1"))
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

        public bool Validar()
        {

            if ((txtClave.Text == "") || (txtNombre.Text == "") || (txtNombre.Text == "") || (txtCalle.Text == "") || (txtCiudad.Text == "") || (txtColonia.Text == ""))
            {
                MessageBox.Show("Faltan Llenar campos por llenar");
                return true;
            }
           
            return false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                return;
            }
            try
            {           
                if (btnInsertarPresionado)
                {
                    string linea;

                    linea = "INSERT INTO almacen(clave, nombre, descripcion, estatus, calle, numero, colonia, cp, ciudad) VALUES ('" + txtClave.Text + "', '" + txtNombre.Text + "', '" + txtDescripcion.Text + "', 1 , '" + txtCalle.Text + "', " + msktxtNumero.Text + ", '" + txtColonia.Text + "', '" + mskCP.Text + "',  '" + txtCiudad.Text + "')";
                    Conexion.RegistrarLog("insert en  almacen " + txtDescripcion.Text);
                    Conexion.Insertar(linea);
                  
                }
                if (btnModificarPresionado)
                {
                    DialogResult dialogresult = MessageBox.Show("Realmente desea guardar los cambios", "Mensaje", MessageBoxButtons.YesNo);
                    if (dialogresult == DialogResult.Yes)
                    {
                        string linea;

                        linea = "UPDATE almacen SET nombre='" + txtNombre.Text + "', descripcion='" + txtDescripcion.Text + "', estatus='1', calle='" + txtCalle.Text + "', numero='" + msktxtNumero.Text + "', colonia='" + txtColonia.Text + "', cp='" + mskCP.Text + "', ciudad='" + txtCiudad.Text + "', clave='" + txtClave.Text + "' WHERE idAlmacen=" + straux;
                        Conexion.RegistrarLog("modifico almacen a: " + txtDescripcion.Text);
                        Conexion.Insertar(linea);
                    }
                    else
                    {
                        return;
                    }
                }
                if (btnEliminarPresionado)
                {

                        string linea;
                    DialogResult dialogresult = MessageBox.Show("Realmente desea guardar los cambios", "Mensaje", MessageBoxButtons.YesNo);
                    if (dialogresult == DialogResult.Yes)
                    {
                        linea = "UPDATE almacen SET  estatus= 0 WHERE idAlmacen= " + straux;
                            Conexion.RegistrarLog("Elimino almacen " + txtDescripcion.Text);
                            Conexion.Insertar(linea);
                            Limpiar();
                        }
                }
                btnCancelar_Click(sender, e);
            }
            catch (Exception)
            {

                return;
            }
      
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            btnInsertarPresionado = true;
            txtClave.Enabled = true;
            Habilitar();
            gpBAcciones.Visible = true;
            gpBConsultas.Visible = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (Conexion.ValidarRegistro("SELECT * FROM almacen WHERE estatus = 1"))
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

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void frmAlmacen_Load(object sender, EventArgs e)
        {
            Deshabilitar();

            gpBBuscar.Visible = false;
            gpBAcciones.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
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
