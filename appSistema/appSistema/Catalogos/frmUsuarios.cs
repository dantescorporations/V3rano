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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();

           
        }
        bool btnInsertarPresionado = false;
        bool btnModificarPresionado = false;
        bool btnEliminarPresionado= false;
        public static int estado;
        public static int municipio;
        public static int colonia;
        public static int codigopost;
        string straux;
        DataRow dr;

        public void Habilitar()
        {
            txtRFC.Enabled=true;
            txtNombre.Enabled=true;
            txtUsuario.Enabled=true;

            txtAP.Enabled=true;
            txtAM.Enabled=true;
            txtEstado.Enabled=true;
            txtTelefono.Enabled=true;
            txtCalle.Enabled=true;
            msktxtNumero.Enabled=true;
            txtColonia.Enabled=true;
            txtCiudad.Enabled=true;
            cboPuesto.Enabled=true;
            cboDepartamento.Enabled = true;
            txtContraseña.Enabled = true;

        }
        public void Deshabilitar()
        {
            txtRFC.Enabled = false;
            txtNombre.Enabled = false;
            txtUsuario.Enabled = false;

            txtAP.Enabled = false;
            txtAM.Enabled = false;
            txtEstado.Enabled = false;
            txtTelefono.Enabled = false;
            txtCalle.Enabled = false;
            msktxtNumero.Enabled = false;
            txtColonia.Enabled = false;
            txtCiudad.Enabled = false;
            cboPuesto.Enabled = false;
            cboDepartamento.Enabled = false;
            txtContraseña.Enabled = false;

       

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
                    else if (control is ComboBox)
                    {
                        (control as ComboBox).Text = "";
                    }

                    else
                        func(control.Controls);
            };

            func(Controls);
            //cboPuesto.Text = "";
            //cboDepartamento.Text = "";

        }
        private void btnBuscarPlan_Click(object sender, EventArgs e)
        {
            try
            {
                frmBuscar frm = new frmBuscar();
                frm.Consulta = "SELECT * FROM vista_empleado";
                frm.ShowDialog();
                straux = frm.ID;
                if (straux.Trim() == "")
                    return;

                 dr = Conexion.ObtenerDatos("select * from empleado  where  idEmpleado= '" + straux + "'");

                txtRFC.Text = dr.ItemArray[10].ToString();
                txtNombre.Text = dr.ItemArray[1].ToString();
                txtUsuario.Text = dr.ItemArray[11].ToString();

                txtAP.Text = dr.ItemArray[2].ToString();
                txtAM.Text = dr.ItemArray[3].ToString();
                txtTelefono.Text = dr.ItemArray[4].ToString();
                txtCalle.Text = dr.ItemArray[5].ToString();
                msktxtNumero.Text = dr.ItemArray[6].ToString();
                cboPuesto.SelectedValue = dr.ItemArray[15].ToString();
                cboDepartamento.SelectedValue = dr.ItemArray[16].ToString();
                actua();
            }
            catch (Exception)
            {

                return;
            }
        }

        public void actua()
        {
            DataRow da = Conexion.ObtenerDatos("SELECT E.Estado,C.Colonia,M.Municipio,C.`Codigo postal`, EM.colonia,EM.estado,EM.municipio " +
                "FROM empleado EM " +
                "inner join colonia C on EM.colonia = C.idMunicipio " +
                "inner join municipio M on EM.municipio = M.idMunicipio " +
                "inner join estado E on EM.Estado = E.idEstado " +
                "where C.Estado = M.idEstado and EM.idEmpleado = " + straux);

            estado = Convert.ToInt32(da.ItemArray[4].ToString());
            colonia = Convert.ToInt32(da.ItemArray[3].ToString());
            municipio = Convert.ToInt32(da.ItemArray[5].ToString());
            txtEstado.Text = da.ItemArray[0].ToString();
            txtColonia.Text = da.ItemArray[1].ToString();
            txtCiudad.Text = da.ItemArray[2].ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (Conexion.ValidarRegistro("SELECT * FROM empleado WHERE estatus = 1"))
            {
                gpBConsultas.Visible = false;
                gpBBuscar.Visible = true;
                gpBAcciones.Visible = true;
                txtRFC.Enabled = false;
                btnModificarPresionado = true;
                Habilitar();

                txtUsuario.Enabled = false;
                txtContraseña.Enabled = false;
                cboAdministrador.Enabled = false;
                btnBuscarPlan_Click(sender, e);
            }
            else
            {
                Conexion.MostrarMensaje("No existen Registros");
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Deshabilitar();
                if (btnInsertarPresionado)
                {
                    string linea;
                    //eliminar la siguiente linea//
                    Conexion.SUsuario = "1";
                    // 
                    linea = "INSERT INTO empleado (nombre,a_Paterno, a_Materno, telefono, calle, numero, colonia, municipio, estado, rfc, usuario, password, administrador, estatus, idPuesto, idDepartamento) VALUES ('" + txtNombre.Text + "', '" + txtAP.Text + "','" + txtAM.Text + "', '" + txtTelefono.Text + "', '" + txtCalle.Text + "', '" + msktxtNumero.Text + "', '" + colonia + "', '" + municipio + "', '" + estado + "', '" + txtRFC.Text + "', '" + txtUsuario.Text + "', '" + txtContraseña.Text + "', '" + cboAdministrador.SelectedValue + "','1', '" + cboPuesto.SelectedValue + "',' " + cboDepartamento.SelectedValue + "')";
                    Conexion.RegistrarLog("Inserto usuario con el RFC " + txtRFC.Text);
                    Conexion.Insertar(linea);

                }
                if (btnModificarPresionado)
                {
                    string linea;

                    linea = "UPDATE empleado SET nombre='" + txtNombre.Text + "', a_Paterno='" + txtAP.Text + "', a_Materno='" + txtAM.Text + "', telefono='" + txtTelefono.Text + "', calle='" + txtCalle.Text + "', numero='" + msktxtNumero.Text + "', colonia='" + colonia + "', municipio='" + municipio + "', estado='" + estado + "', rfc='" + txtRFC.Text + "', usuario='" + txtUsuario.Text + "', idPuesto='" + cboPuesto.SelectedValue + "', idDepartamento='" + cboDepartamento.SelectedValue + "' WHERE idEmpleado= " + straux;
                    Conexion.RegistrarLog("Modifico usuario con el RFC " + txtRFC.Text);
                    Conexion.Insertar(linea);
                    
                    btnBuscarPlan_Click( sender,  e);

                }
                btnInsertarPresionado = false;
                btnModificarPresionado = false;
                Limpiar();
            }
            catch (Exception)
            {

                return;
            }
         
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            try
            {
                Deshabilitar();
                string query = "SELECT idDepartamento, nombre FROM departamento WHERE estatus=1";
                string query2 = "SELECT idPuesto, nombre FROM puesto WHERE estatus=1";
                Conexion.LlenarComboBox(cboDepartamento, query);
                Conexion.LlenarComboBox(cboPuesto, query2);
                if (cboDepartamento.Items.Count == 0)
                {


                    DialogResult dialogresult = MessageBox.Show("No existe registros de Departamentos, Desea agregar un Departamento", "Mensaje", MessageBoxButtons.YesNo);
                    if (dialogresult == DialogResult.Yes)
                    {



                    }
                    else
                    {

                    }
                }
                if (cboPuesto.Items.Count == 0)
                {


                    DialogResult dialogresult = MessageBox.Show("No existe registros de Puestos, Desea agregar un Puesto", "Mensaje", MessageBoxButtons.YesNo);
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cboAdministrador_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            gpBConsultas.Visible = false;
            gpBAcciones.Visible = true;
            btnInsertarPresionado = true;
            cboAdministrador.Enabled = true;
            Habilitar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (Conexion.ValidarRegistro("SELECT * FROM empleado WHERE estatus = 1"))
            {
                gpBConsultas.Visible = false;
                gpBBuscar.Visible = true;
                gpBAcciones.Visible = true;
                txtRFC.Enabled = false;
                btnEliminarPresionado = true;
                btnBuscarPlan_Click(sender, e);
            }
            else
            {
                Conexion.MostrarMensaje("No existen Registros");
            }

        }

        public bool Validar()
        {
            if ((txtContraseña.Text == "") || (txtUsuario.Text == "") || (txtNombre.Text == "") || (txtAM.Text == "") || (txtAP.Text == "") || (txtRFC.Text == "") || (txtCalle.Text == "") || (msktxtNumero.Text == ""))
            {
                MessageBox.Show("Faltan Llenar campos");
                return true;
            }
           
         dr= Conexion.ObtenerDatos("Select Usuario From empleado where Usuario='"+txtUsuario.Text+"'");
            if (dr.ItemArray[0].ToString()==txtUsuario.Text)
            {
                MessageBox.Show("El usuario ya esta en uso");
                return true;
            }
            return false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
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
        
                    linea = "INSERT INTO empleado (nombre, a_Paterno, a_Materno, telefono, calle, numero, colonia, municipio, estado, rfc, usuario, password, administrador, estatus, idPuesto, idDepartamento) VALUES ('" + txtNombre.Text + "', '" + txtAP.Text + "','" + txtAM.Text + "', '" + txtTelefono.Text + "', '" + txtCalle.Text + "', '" + msktxtNumero.Text + "', '" + colonia + "', '" + municipio + "', '" + estado + "', '" + txtRFC.Text + "', '" + txtUsuario.Text + "', MD5('" + txtContraseña.Text + "'), '" + cboAdministrador.SelectedValue + "','1', '" + cboPuesto.SelectedValue + "',' " + cboDepartamento.SelectedValue + "')";
                    Conexion.RegistrarLog("Inserto usuario con el RFC " + txtRFC.Text);
                    Conexion.Insertar(linea);
                    BtnCancelar_Click(sender, e);

                }
                if (btnModificarPresionado)
                {
                    DialogResult dialogresult = MessageBox.Show("Realmente desea guardar los cambios", "Mensaje", MessageBoxButtons.YesNo);
                    if (dialogresult == DialogResult.Yes)
                    {
                        if ((txtContraseña.Text == "") || (txtUsuario.Text == "") || (txtNombre.Text == "") || (txtAM.Text == "") || (txtAP.Text == "") || (txtRFC.Text == "") || (txtCalle.Text == "") || (msktxtNumero.Text == ""))
                        {
                            MessageBox.Show("Faltan Llenar campos");
                            return;
                        }

                        string linea;

                        linea = "UPDATE empleado SET nombre='" + txtNombre.Text + "', a_Paterno='" + txtAP.Text + "', a_Materno='" + txtAM.Text + "', telefono='" + txtTelefono.Text + "', calle='" + txtCalle.Text + "', numero='" + msktxtNumero.Text + "', colonia='" + colonia + "', municipio='" + municipio + "', estado='" + estado + "', rfc='" + txtRFC.Text + "', usuario='" + txtUsuario.Text + "', password='" + txtContraseña.Text + "', administrador='" + cboAdministrador.SelectedValue + "', estatus='1', idPuesto='" + cboPuesto.SelectedValue + "', idDepartamento='" + cboDepartamento.SelectedValue + "' WHERE idEmpleado= " + straux;
                        Conexion.RegistrarLog("Modifico usuario con el RFC " + txtRFC.Text);
                        Conexion.Insertar(linea);
                        BtnCancelar_Click(sender, e);
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
                        linea = "UPDATE empleado SET  estatus= 0 WHERE idEmpleado= " + straux;
                            Conexion.RegistrarLog("Elimino usuario con el RFC " + txtRFC.Text);
                            Conexion.Insertar(linea);
                            BtnCancelar_Click(sender, e);
                        }
                        else { return; }
                   
                }

                BtnCancelar_Click(sender, e);
            }
            catch (Exception)
            {

                return;
            }

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            gpBConsultas.Visible = true;
            gpBAcciones.Visible = false;
            gpBBuscar.Visible = false;
            Deshabilitar();
            Limpiar();
            btnEliminarPresionado = false;
            btnInsertarPresionado = false;
            btnModificarPresionado = false;
        }

        private void btnBsr_Click(object sender, EventArgs e)
        {
            frmCPostales post = new frmCPostales();
            post.ShowDialog();
        }
    }
}
