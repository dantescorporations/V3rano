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
    public partial class frmTipo_De_Obligacion : Form
    {
        public frmTipo_De_Obligacion()
        {
            InitializeComponent();
        }


        bool btnInsertarPresionado = false;
        bool btnModificarPresionado = false;
        string straux;
        bool btnEliminarPresionado = false;


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

                    linea = "INSERT INTO tipoobligacion(descripcion, estatus) VALUES ('" + txtDescripcion.Text + "',1)";
                    Conexion.RegistrarLog("Inserto tipo de obligacion " + txtDescripcion.Text);
                    Conexion.Insertar(linea);

                }
                if (btnModificarPresionado)
                {
                    string linea;

                    linea = " UPDATE tipoobligacion SET descripcion=  '" + txtDescripcion.Text + "',estatus=1 WHERE idTipoObligacion=" + straux;
                    Conexion.RegistrarLog("Modifico tipo de obligacion " + txtDescripcion.Text);
                    Conexion.Insertar(linea);
                }
                if (btnEliminarPresionado)
                {
                    string linea;

                    linea = "UPDATE tipoobligacion SET  estatus= 0 WHERE idTipoObligacion= " + straux;
                    Conexion.RegistrarLog("Elimino tipo de obligacion " + txtDescripcion.Text);
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

        private void btnBuscarPlan_Click(object sender, EventArgs e)
        {

            try
            {
                frmBuscar frm = new frmBuscar();
                frm.Consulta = "SELECT * FROM vista_tipoobligacion";
                frm.ShowDialog();
                straux = frm.ID;
                if (straux.Trim() == "")
                    return;

                DataRow dr = Conexion.ObtenerDatos("SELECT * FROM tipoobligacion where idTipoObligacion = '" + straux + "'");

                txtDescripcion.Text = dr.ItemArray[1].ToString();
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
            if (Conexion.ValidarRegistro("SELECT * FROM tipoobligacion WHERE estatus = 1"))
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

        private void frmTipo_De_Obligacion_Load(object sender, EventArgs e)
        {
            Deshabilitar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Conexion.ValidarRegistro("SELECT * FROM tipoobligacion WHERE estatus = 1"))
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
