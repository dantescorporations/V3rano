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
    public partial class frmTipo_De_Producto : Form
    {
        public frmTipo_De_Producto()
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

                    linea = "INSERT INTO tipoproducto(descripcion,estatus) VALUES ('" + txtDescripcion.Text + "',1)";
                    Conexion.RegistrarLog("Inserto tipo de producto " + txtDescripcion.Text);
                    Conexion.Insertar(linea);

                }
                if (btnModificarPresionado)
                {
                    string linea;
                    DialogResult dialogresult = MessageBox.Show("Esta seguro de realizar los cambios", "Mensaje", MessageBoxButtons.YesNo);
                    if (dialogresult == DialogResult.Yes)
                    {
                        linea = " UPDATE tipoproducto SET descripcion=  '" + txtDescripcion.Text + "',estatus=1 WHERE idTipoProducto=" + straux;
                        Conexion.RegistrarLog("Modifico tipo de producto " + txtDescripcion.Text);
                        Conexion.Insertar(linea);
                    }
                    else
                    {
                        return;
                    }
                }
                if (btnEliminarPresionado)
                {
                    if (Conexion.ValidarEstatus("SELECT * FROM producto WHERE estatus=1 and idTipoProducto=" + straux))
                    {

                        MessageBox.Show("El Registro no puede ser Eliminado por que esta siendo usado en otros campos");
                        return;
                    }
                    string linea;
                    DialogResult dialogresult = MessageBox.Show("Realmente desea guardar los cambios", "Mensaje", MessageBoxButtons.YesNo);
                    if (dialogresult == DialogResult.Yes)
                    {
                        linea = "UPDATE tipoproducto SET  estatus= 0 WHERE idTipoProducto= " + straux;
                        Conexion.RegistrarLog("Elimino tipo de producto " + txtDescripcion.Text);
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

        private void frmTipo_De_Producto_Load(object sender, EventArgs e)
        {
            Deshabilitar();
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

                DataRow dr = Conexion.ObtenerDatos("SELECT * FROM tipoproducto where idTipoProducto = '" + straux + "'");

                txtDescripcion.Text = dr.ItemArray[1].ToString();
         
            }
            catch (Exception)
            {

                return;
            }
      
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (Conexion.ValidarRegistro("SELECT * FROM tipoproducto WHERE estatus = 1"))
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

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            btnInsertarPresionado = true;
        
            Habilitar();
            gpBAcciones.Visible = true;
            gpBConsultas.Visible = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Conexion.ValidarRegistro("SELECT * FROM tipoproducto WHERE estatus = 1"))
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
