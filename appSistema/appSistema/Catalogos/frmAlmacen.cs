using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using appSistema;

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
        public static int Estado;
        public static int Municipio;
        public static int colonia;
        public static int codigopost;
        string straux;

        public void Habilitar()
        {
            
            txtDescripcion.Enabled = true;
            txtNombre.Enabled = true;
            txtCalle.Enabled = true;
            msktxtNumero.Enabled = true;
            txtColonia.Visible = false;
            txtCiudad.Visible = false;
            mskCP.Visible = false;
            label4.Visible = false;
            label3.Visible = false;
            label6.Visible = false;
            btnBsr.Enabled = true;
          
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
            btnBsr.Enabled = false;
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
                

                txtClave.Text = dr.ItemArray[1].ToString();
                txtDescripcion.Text = dr.ItemArray[2].ToString();
                txtNombre.Text = dr.ItemArray[3].ToString();
                txtCalle.Text = dr.ItemArray[4].ToString();
                msktxtNumero.Text = dr.ItemArray[5].ToString();
                txtColonia.Visible = true;
                txtCiudad.Visible = true;
                mskCP.Visible = true;
                label4.Visible = true;
                label3.Visible = true;
                label6.Visible = true;
                actu();
            }
            catch (Exception)
            {

                return;
            }
        
        }
        public void actu()
        {
            DataRow ds = Conexion.ObtenerDatos("SELECT C.Colonia,M.Municipio,C.`Codigo postal` " +
                       "FROM almacen A inner join colonia C on A.colonia = C.idMunicipio " +
                       "inner join municipio M on A.ciudad = M.idMunicipio " +
                       "inner join estado E on A.idEstado = E.idEstado " +
                       "where C.Estado = M.idEstado and  A.idAlmacen = '" + straux + "'");
            txtColonia.Text = ds.ItemArray[0].ToString();
            txtCiudad.Text = ds.ItemArray[1].ToString();
            mskCP.Text = ds.ItemArray[2].ToString();
            txtColonia.Enabled = false;
            txtCiudad.Enabled = false;
            mskCP.Enabled = false;

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

            if ((txtClave.Text == "") || (txtNombre.Text == "") || (txtNombre.Text == "") || (txtCalle.Text == ""))
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

                    linea = "INSERT INTO `almacen`(`clave`, `nombre`, `descripcion`, `calle`, `numero`, `colonia`, `ciudad`, `cp`, `idEstado`, `estatus`) VALUES ('" + txtClave.Text + "', '" + txtNombre.Text + "', '" + txtDescripcion.Text + "', '" + txtCalle.Text + "', " + msktxtNumero.Text + ", '" + colonia + "', '" + Municipio + "',  '" + codigopost + "',  '" + Estado + "', 1);";
                    Conexion.RegistrarLog("insert en  almacen " + txtDescripcion.Text);
                    Conexion.Insertar(linea);
                  
                }
                if (btnModificarPresionado)
                {
                    DialogResult dialogresult = MessageBox.Show("Realmente desea guardar los cambios", "Mensaje", MessageBoxButtons.YesNo);
                    if (dialogresult == DialogResult.Yes)
                    {
                        string linea;

                        linea = "UPDATE almacen SET nombre='" + txtNombre.Text + "', descripcion='" + txtDescripcion.Text + "', estatus='1', calle='" + txtCalle.Text + "', numero='" + msktxtNumero.Text + "', colonia='" + colonia + "', cp='" + codigopost + "', ciudad='" + Municipio + "', clave='" + txtClave.Text + "' WHERE idAlmacen=" + straux;
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
            if (Conexion.ValidarRegistro("SELECT A.clave,A.nombre,A.Descripcion,A.calle,A.numero,C.Colonia,M.Municipio,C.`Codigo postal` FROM almacen A inner join colonia C on A.colonia = C.idMunicipio inner join municipio M on A.ciudad = M.idMunicipio inner join estado E on A.idEstado = E.idEstado where A.idEstado = M.idEstado "))
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
            txtColonia.Visible = false;
            txtCiudad.Visible = false;
            mskCP.Visible = false;
            label4.Visible = false;
            label3.Visible = false;
            label6.Visible = false;
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

        private void btnBsr_Click(object sender, EventArgs e)
        {
            try
            {
                frmCPostales post = new frmCPostales();
                post.ShowDialog();
            }
            catch (Exception)
            {

                return;
            }
        }
    }
}
