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
    public partial class frmSolicitarCotizacion : Form
    {
        public frmSolicitarCotizacion()
        {
            InitializeComponent();
        }

        bool btnInsertarPresionado = false;
        bool btnModificarPresionado = false;
       
        string straux;
        public void Habilitar()
        {
            txtNumero.Enabled = true;
            txtDescripción.Enabled = true;
            mskFecha.Enabled = true;
            cboEmpleado.Enabled = true;
            cboRequisicion.Enabled = true;
            cboProveedor.Enabled = true;
        }
        public void Deshabilitar()
        {
            txtNumero.Enabled = false;
            txtDescripción.Enabled = false;
            mskFecha.Enabled = false;
            cboEmpleado.Enabled = false;
            cboRequisicion.Enabled = false;
            cboProveedor.Enabled = false;
        }

        public void Limpiar()
        {
            txtNumero.Text = "";
            txtDescripción.Text = "";
            mskFecha.Text = "";
            cboEmpleado.Text = "";
            cboRequisicion.Text = "";
            cboProveedor.Text = "";
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
            if (Conexion.ValidarRegistro("SELECT * FROM soliccotizacion WHERE estatus = 1"))
            {
                btnModificarPresionado = true;
                Habilitar();

                gpBAcciones.Visible = true;
                gpBConsultas.Visible = false;
                gpBBuscar.Visible = true;
                btnBuscar_Click(sender, e);
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

                linea = "INSERT INTO soliccotizacion(NoCotizacion, descripcion, fecha, estatus, idEmpleado, idProveedor, idRequisicion) VALUES ('" + txtNumero.Text + "', '" + txtDescripción.Text + "','" + mskFecha.Text + "', '" + 0 + "','" + cboEmpleado.SelectedValue + "', '" + cboProveedor.SelectedValue + "', '" + cboRequisicion.SelectedValue + "')";

                Conexion.Insertar(linea);
            }
            if (btnModificarPresionado)
            {
                string linea;
                DialogResult dialogresult = MessageBox.Show("Realmente desea guardar los cambios", "Mensaje", MessageBoxButtons.YesNo);
                if (dialogresult == DialogResult.Yes)
                {
                    linea = "UPDATE soliccotizacion SET descripcion ='" + txtDescripción.Text + "', fecha='" + mskFecha.Text + "', idEmpleado='" + cboEmpleado.ValueMember + "', idProveedor='" + cboProveedor.ValueMember + "', idRequisicion='" + cboRequisicion.ValueMember + "' WHERE NoCotizacion= " + straux;

                    Conexion.Modificar(linea);
                }
                else
                {
                    return;
                }
            }
            BtnCancelar_Click(sender, e);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            frmBuscar frm = new frmBuscar();
            frm.Consulta = "SELECT * FROM vista_soliccotizacioncatalogo";
            frm.ShowDialog();
            string straux = frm.ID;
            if (straux.Trim() == "")
                return;

            DataRow dr = Conexion.ObtenerDatos("select * from soliccotizacion where noCotizacion = '" + straux + "'");

            txtNumero.Text = dr.ItemArray[1].ToString();
            txtDescripción.Text = dr.ItemArray[2].ToString();
            mskFecha.Text = dr.ItemArray[3].ToString();
        }

        private void frmSolicitarCotizacion_Load(object sender, EventArgs e)
        {
          Deshabilitar();
            try
            {
                string query = "SELECT idProvedor, empresa FROM provedor WHERE estatus=1";
                string query2 = "SELECT idRequisicion, NoRequisicion FROM requisicion WHERE estatus=1";
                string query3 = "SELECT Id, NombreCompleto FROM vista_empleado";

                Conexion.LlenarComboBox(cboProveedor, query);
                Conexion.LlenarComboBox(cboRequisicion, query2);
                Conexion.LlenarComboBox(cboEmpleado, query3);
                if (cboProveedor.Items.Count == 0)
                {
                    DialogResult dialogresult = MessageBox.Show("No existe registros de Proveedores, Desea agregar un Proveedor", "Mensaje", MessageBoxButtons.YesNo);
                    if (dialogresult == DialogResult.Yes)
                    {
                        
                    }
                    else
                    {
                     
                    }
                }
                if (cboRequisicion.Items.Count == 0)
                {
                    DialogResult dialogresult = MessageBox.Show("No existe registros de Requisicion, Desea agregar una Requisicion", "Mensaje", MessageBoxButtons.YesNo);
                    if (dialogresult == DialogResult.Yes)
                    {


                     
                    }
                    else
                    {
                      
                    }
                }
              

            }
            catch (Exception)
            {

                return;
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
        }
    }
}
