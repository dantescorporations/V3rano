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
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        bool btnInsertarPresionado = false;
        bool btnModificarPresionado = false;
        bool btnEliminarPresionado = false;
        string straux;

        public void Habilitar()
        {
            txtCodigoInterno.Enabled = true;
            txtNombre.Enabled = true;
            txtPrecio.Enabled = true;
            cboTipoProducto.Enabled = true;
            cboUnidad.Enabled = true;
    

        }
        public void Deshabilitar()
        {
            txtCodigoInterno.Enabled = false;
            txtNombre.Enabled = false;
            txtPrecio.Enabled = false;
            cboTipoProducto.Enabled = false;
            cboUnidad.Enabled = false;
            
        }

        public void Limpiar()
        {
            txtCodigoInterno.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            cboTipoProducto.Text = "";
            cboUnidad.Text = "";
        }
        private void Productos_Load(object sender, EventArgs e)
        {

            Deshabilitar();
            string query = "SELECT idTipoProducto,descripcion FROM tipoproducto WHERE estatus=1";
            Conexion.LlenarComboBox(cboTipoProducto, query);

            string query2 = "SELECT idUnidadMedida,unidad FROM unidadmedida WHERE estatus=1";
            Conexion.LlenarComboBox(cboUnidad, query2);



        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscarPlan_Click(object sender, EventArgs e)
        {
            try
            {
                frmBuscar frm = new frmBuscar();
                frm.Consulta = "SELECT * FROM vista_producto";
                frm.ShowDialog();
                straux = frm.ID;
                if (straux.Trim() == "")
                    return;

                DataRow dr = Conexion.ObtenerDatos("SELECT * FROM producto where idProducto = '" + straux + "'");

                txtCodigoInterno.Text = dr.ItemArray[3].ToString();
                txtNombre.Text = dr.ItemArray[1].ToString();
                txtPrecio.Text = dr.ItemArray[2].ToString();
                cboTipoProducto.SelectedValue = dr.ItemArray[5].ToString();
                cboUnidad.SelectedValue = dr.ItemArray[6].ToString();
            }
            catch (Exception)
            {

                return;
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

                    linea = "INSERT INTO producto (nombre, precio, codigo, estatus, idTipoProducto,idUnidadMedida) VALUES ('" + txtNombre.Text + "','" + txtPrecio.Text + "','" + txtCodigoInterno.Text + "',1 , '" + cboTipoProducto.SelectedValue + "', '" + cboUnidad.SelectedValue + "')";
                    Conexion.RegistrarLog("Inserto producto " + txtCodigoInterno.Text);
                    Conexion.Insertar(linea);
                }
                if (btnModificarPresionado)
                {
                    string linea;

                    linea = "UPDATE producto SET nombre='" + txtNombre.Text + "',precio='" + txtPrecio.Text + "',codigo='" + txtCodigoInterno.Text + "',   estatus='1', idTipoProducto='" + cboTipoProducto.SelectedValue + "', idUnidadMedida='" + cboUnidad.SelectedValue + "' WHERE idProducto=" + straux;
                    Conexion.RegistrarLog("Modifico producto producto " + txtCodigoInterno.Text);
                    Conexion.Insertar(linea);
                }
                if (btnEliminarPresionado)
                {
                    string linea;

                    linea = "UPDATE producto SET  estatus= 0 WHERE idProducto= " + straux;
                    Conexion.RegistrarLog("Elimino producto " + txtCodigoInterno.Text);
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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
            if (Conexion.ValidarRegistro("SELECT * FROM producto WHERE estatus = 1"))
            {

                btnModificarPresionado = true;
                Habilitar();
                txtCodigoInterno.Enabled = false;
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
            if (Conexion.ValidarRegistro("SELECT * FROM producto WHERE estatus = 1"))
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
