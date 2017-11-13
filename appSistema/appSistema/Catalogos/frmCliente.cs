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
    public partial class frmCliente : Form
    {
        bool btnInsertarPresionado = false;
        bool btnModificarPresionado = false;
        bool btnEliminarPresionado = false;
        string straux;
        DataRow dr;
        public frmCliente()
        {
            InitializeComponent();
        }


        public void Habilitar()
        {

            txtRS.Enabled = true;
            mskTelefono.Enabled = true;
            txtCalle.Enabled = true;
            txtnumero.Enabled = true;
            txtCol.Enabled = true;
            txtEdo.Enabled = true;
            txtCd.Enabled = true;

            txtClave.Enabled = true;
            txtNC.Enabled = true;
            mskCP.Enabled = true;
        }
        public void Deshabilitar()
        {
            txtRS.Enabled = false;
            mskTelefono.Enabled = false;
            txtCalle.Enabled = false;
           txtnumero.Enabled = false;
            txtCol.Enabled = false;
            txtEdo.Enabled = false;
            txtCd.Enabled = false;

            txtNC.Enabled = false;
            txtClave.Enabled = false;
            mskCP.Enabled = false;
        }
       
        public void Limpiar()
        {
            txtRS.Text = "";
            mskTelefono.Text = "";
            txtCalle.Text = "";
            txtnumero.Text = "";
            txtCol.Text = "";
            txtEdo.Text = "";
            txtCd.Text = "";

            txtClave.Text = "";
            txtNC.Text = "";
            mskCP.Text = "";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
           

            if (Conexion.ValidarRegistro("SELECT * FROM cliente WHERE estatus = 1"))
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
    
        private void cmbEstatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            Deshabilitar();


        }


        private void btnInsertar_Click(object sender, EventArgs e)
        {
            btnInsertarPresionado = true;
            txtClave.Enabled = true;
            Habilitar();
            gpBAcciones.Visible = true;
            gpBConsultas.Visible = false;
        }

        public bool Validar()
        {
            if ((txtClave.Text == "") || (txtRS.Text == "") || (txtNC.Text == "") || (mskTelefono.Text == "") )
            {
                MessageBox.Show("Faltan llenar campos");
                return true;
            }         
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

                    linea = "INSERT INTO cliente(razonSocial, telefono, calle, numero, colonia, estado, municipio, estatus, nombreComercial, clave, cp) VALUES ('" + txtRS.Text + "', '" + mskTelefono.Text + "','" + txtCalle.Text + "', '" + txtnumero.Text + "', '" + txtCol.Text + "', '" + txtEdo.Text + "', '" + txtCd.Text + "', '1', '" + txtNC.Text + "', '" + txtClave.Text + "', '" + mskCP.Text + "')";
                    Conexion.RegistrarLog("Inserto cliente " + txtClave.Text);
                    Conexion.RegistrarLog("Se registro Cliente con razon social"+txtRS.Text);
                    Conexion.Insertar(linea);

                }        
                if (btnModificarPresionado)
                {
                    DialogResult dialogresult = MessageBox.Show("Realmente desea guardar los cambios", "Mensaje", MessageBoxButtons.YesNo);
                    if (dialogresult == DialogResult.Yes)
                    {
                        string linea;

                        linea = "UPDATE cliente SET razonSocial='" + txtRS.Text + "', telefono='" + mskTelefono.Text + "', calle='" + txtCalle.Text + "', numero='" + txtnumero.Text + "', colonia='" + txtCol.Text + "', estado='" + txtEdo.Text + "', municipio='" + txtCd.Text + "', estatus='1', nombreComercial='" + txtNC.Text + "', clave='" + txtClave.Text + "', cp='" + mskCP.Text + "' WHERE idCliente= " + straux;
                        Conexion.RegistrarLog("Modifico cliente " + txtClave.Text);
                        Conexion.Insertar(linea);
                    }
                    else
                    {
                        return;
                    }
                }
                if (btnEliminarPresionado)
                {

                    DialogResult dialogresult = MessageBox.Show("Realmente desea guardar los cambios", "Mensaje", MessageBoxButtons.YesNo);
                    if (dialogresult == DialogResult.Yes)
                    {
                        string linea;

                        linea = "UPDATE cliente SET  estatus= 0 WHERE idCliente= " + straux;
                        Conexion.RegistrarLog("Elimino cliente " + txtClave.Text);
                        Conexion.Insertar(linea);
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

        private void btnBuscarPlan_Click(object sender, EventArgs e)
        {
            try
            {
                frmBuscar frm = new frmBuscar();
                frm.Consulta = "SELECT * FROM vista_cliente";
                frm.ShowDialog();
                straux = frm.ID;
                if (straux.Trim() == "")
                    return;

                dr = Conexion.ObtenerDatos("select * from cliente where idCliente = '" + straux + "'");
                txtClave.Text = dr.ItemArray[9].ToString();
                txtRS.Text = dr.ItemArray[1].ToString();
                mskTelefono.Text = dr.ItemArray[2].ToString();
                txtCalle.Text = dr.ItemArray[3].ToString();
                txtnumero.Text = dr.ItemArray[4].ToString();
                txtCol.Text = dr.ItemArray[5].ToString();
                txtEdo.Text = dr.ItemArray[6].ToString();
                txtCd.Text = dr.ItemArray[7].ToString();
                txtNC.Text = dr.ItemArray[8].ToString();
                txtNC.Text = dr.ItemArray[10].ToString();
                mskCP.Text = dr.ItemArray[11].ToString();
            }
            catch (Exception)
            {
                return;
            }
        
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Conexion.ValidarRegistro("SELECT * FROM cliente WHERE estatus = 1"))
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
