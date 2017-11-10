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
    public partial class frmPuesto : Form
    {
        public frmPuesto()
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

                    linea = "INSERT INTO puesto(nombre) VALUES ('" + txtDescripcion.Text + "')";
                    Conexion.RegistrarLog("Inserto puesto " + txtDescripcion.Text);
                    Conexion.Insertar(linea);

                }
                if (btnModificarPresionado)
                {
                    string linea;

                    linea = " UPDATE puesto SET estatus=1,nombre=  '" + txtDescripcion.Text + "' WHERE idPuesto=" + straux;
                    Conexion.RegistrarLog("Modifico puesto " + txtDescripcion.Text);
                    Conexion.Insertar(linea);
                }
                if (btnEliminarPresionado)
                {
                    string linea;

                    linea = "UPDATE puesto SET  estatus= 0 WHERE idPuesto= " + straux;
                    Conexion.RegistrarLog("Elimino puesto " + txtDescripcion.Text);
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

        private void btnBuscarPlan_Click(object sender, EventArgs e)
        {
            try
            {
                frmBuscar frm = new frmBuscar();
                frm.Consulta = "SELECT * FROM vista_puesto";
                frm.ShowDialog();
                straux = frm.ID;
                if (straux.Trim() == "")
                    return;

                DataRow dr = Conexion.ObtenerDatos("SELECT * FROM puesto where idPuesto = '" + straux + "'");

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
            if (Conexion.ValidarRegistro("SELECT * FROM puesto WHERE estatus = 1"))
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

        private void frmPuesto_Load(object sender, EventArgs e)
        {
            Deshabilitar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Conexion.ValidarRegistro("SELECT * FROM puesto WHERE estatus = 1"))
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
