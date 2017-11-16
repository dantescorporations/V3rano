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
        public static int estado;
        public static int municipio;
        public static int colonia;
        public static int codigopost;
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
            txtCd.Enabled = true;
            txtCol.Visible = false;
            txtEdo.Visible = false;
            txtCd.Visible = false;
            mskCP.Visible = false;
            txtClave.Enabled = true;
            txtNC.Enabled = true;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            btnBsr.Enabled = true;
        }
        public void Deshabilitar()
        {
            txtRS.Enabled = false;
            mskTelefono.Enabled = false;
            txtCalle.Enabled = false;
           txtnumero.Enabled = false;
            txtNC.Enabled = false;
            txtClave.Enabled = false;
            txtCol.Visible = false;
            txtEdo.Visible = false;
            txtCd.Visible = false;
            mskCP.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            btnBsr.Enabled = false;
        }
       
        public void Limpiar()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                    {
                        (control as TextBox).Clear();
                    }
                    else if (control is MaskedTextBox)
                    {
                        (control as MaskedTextBox).Clear();
                    }

                    else
                        func(control.Controls);
            };

            func(Controls);
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

                    linea = "INSERT INTO cliente(razonSocial, telefono, calle, numero, colonia, estado, municipio, estatus, nombreComercial, clave, cp) VALUES ('" + txtRS.Text + "', '" + mskTelefono.Text + "','" + txtCalle.Text + "', '" + txtnumero.Text + "', '" + colonia + "', '" + estado + "', '" + municipio + "', '1', '" + txtNC.Text + "', '" + txtClave.Text + "', '" + codigopost + "')";
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

                        linea = "UPDATE cliente SET razonSocial='" + txtRS.Text + "', telefono='" + mskTelefono.Text + "', calle='" + txtCalle.Text + "', numero='" + txtnumero.Text + "', colonia='" + colonia + "', estado='" + estado + "', municipio='" + municipio + "', estatus='1', nombreComercial='" + txtNC.Text + "', clave='" + txtClave.Text + "', cp='" + codigopost + "' WHERE idCliente= " + straux;
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
                    if (Conexion.ValidarEstatus("SELECT * FROM contactocliente WHERE estatus=1 and idcliente=" + straux))
                    {

                        MessageBox.Show("El Registro no puede ser Eliminado por que esta siendo usado en otros campos");
                        return;
                    }
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
                txtClave.Text = dr.ItemArray[10].ToString();
                txtRS.Text = dr.ItemArray[1].ToString();
                mskTelefono.Text = dr.ItemArray[2].ToString();
                txtCalle.Text = dr.ItemArray[3].ToString();
                txtnumero.Text = dr.ItemArray[4].ToString();
                txtNC.Text = dr.ItemArray[9].ToString();
                txtCol.Visible = true;
                txtEdo.Visible = true;
                txtCd.Visible = true;
                mskCP.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                actua();
            }
            catch (Exception)
            {
                return;
            }
        
        }
        public void actua()
        {
            DataRow ds = Conexion.ObtenerDatos("SELECT E.Estado,C.Colonia,M.Municipio,C.`Codigo postal`,CL.colonia,CL.estado,CL.municipio,CL.cp " +
                "FROM cliente CL " +
                "inner join colonia C on CL.colonia = C.idMunicipio " +
                "inner join municipio M on CL.municipio = M.idMunicipio " +
                "inner join estado E on CL.Estado = E.idEstado " +
                "where C.Estado = M.idEstado and CL.idCliente = " + straux);
            txtCol.Text = ds.ItemArray[1].ToString();
            txtEdo.Text = ds.ItemArray[0].ToString();
            txtCd.Text = ds.ItemArray[2].ToString();
            mskCP.Text = ds.ItemArray[3].ToString();
            txtCol.Enabled = false;
            txtEdo.Enabled = false;
            txtCd.Enabled = false;
            mskCP.Enabled = false;
            estado = Convert.ToInt32(ds.ItemArray[5]);
            municipio = Convert.ToInt32(ds.ItemArray[6]);
            colonia = Convert.ToInt32(ds.ItemArray[4]);
            codigopost = Convert.ToInt32(ds.ItemArray[7]);

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

        private void btnBsr_Click(object sender, EventArgs e)
        {
            frmCPostales cPostales = new frmCPostales();
            cPostales.ShowDialog();
        }
    }
}
