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
    public partial class frmProveedores : Form
    {
        public frmProveedores()
        {
            InitializeComponent();
        }
        bool btnInsertarPresionado = false;
        bool btnModificarPresionado = false;
        bool btnEliminarPresionado = false;
        public static int estado;
        public static int municipio;
        public static int colonia;
        public static int codigopost;
        string straux;


        public void Habilitar()
        {
            txtClave.Enabled = true;
            txtEmpresa.Enabled = true;
            mskTelefono.Enabled = true;
            txtCalle.Enabled = true;
            txtNumero.Enabled = true;
            txtColonia.Visible = false;
            txtEstado.Visible = false;
            txtCiudad.Visible = false;
            label6.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            btnBsr.Enabled = true;
        }
        public void Deshabilitar()
        {

            txtClave.Enabled = false;
            txtEmpresa.Enabled = false;
            mskTelefono.Enabled = false;
            btnBsr.Enabled = false;
            txtCiudad.Enabled = false;
            txtCalle.Enabled = false;
            txtNumero.Enabled = false;
            txtColonia.Enabled = false;
           
            txtEstado.Enabled = false;
            
        }
       
        public void Limpiar()
        {
            txtClave.Text = "";
            txtEmpresa.Text = "";
            mskTelefono.Text = "";

            txtCiudad.Text = "";
            txtCalle.Text = "";
            txtNumero.Text = "";
            txtColonia.Text = "";
            txtEstado.Text = "";
        }

        private void btnBuscarPlan_Click(object sender, EventArgs e)
        {
            try
            {
                frmBuscar frm = new frmBuscar();
                frm.Consulta = "SELECT * FROM vista_provedor";
                frm.ShowDialog();
                straux = frm.ID;
                if (straux.Trim() == "")
                    return;

                DataRow dr = Conexion.ObtenerDatos("select * from provedor where idProvedor = '" + straux + "'");

                txtClave.Text = dr.ItemArray[10].ToString();
                txtEmpresa.Text = dr.ItemArray[1].ToString();
                mskTelefono.Text = dr.ItemArray[2].ToString();
                txtCalle.Text = dr.ItemArray[3].ToString();
                txtNumero.Text = dr.ItemArray[4].ToString();
                txtColonia.Visible = true;
                txtCiudad.Visible = true;
                txtEstado.Visible = true;
                label6.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                actua();
            }
            catch (Exception)
            {
                return;
            }
        }

        public void actua()
        {
            DataRow data = Conexion.ObtenerDatos("SELECT C.Colonia,M.Municipio,E.Estado,C.`Codigo postal`, P.colonia,P.estado,P.municipio " +
                "FROM provedor P " +
                "inner join colonia C on P.colonia = C.idMunicipio " +
                "inner join municipio M on P.municipio = M.idMunicipio " +
                "inner join estado E on P.Estado = E.idEstado " +
                "where C.Estado = M.idEstado and P.idProvedor = " + straux);
            txtColonia.Enabled = false;
            txtEstado.Enabled = false;
            txtCiudad.Enabled = false;
            txtColonia.Text = data.ItemArray[0].ToString();
            txtCiudad.Text = data.ItemArray[1].ToString();
            txtEstado.Text = data.ItemArray[2].ToString();
            estado = Convert.ToInt32(data.ItemArray[5].ToString());
            municipio = Convert.ToInt32(data.ItemArray[6].ToString());
            colonia = Convert.ToInt32(data.ItemArray[4].ToString());
            codigopost = Convert.ToInt32(data.ItemArray[3].ToString());
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

                    linea = "INSERT INTO provedor(empresa,telefono,calle,numero,colonia,municipio,estado,estatus,clave)VALUES ('" + txtEmpresa.Text + "', '" + mskTelefono.Text + "','" + txtCalle.Text + "', '" + txtNumero.Text + "', '" + colonia + "', '" + municipio + "', '" + estado + "', '1', '" + txtClave.Text + "')";
                    Conexion.RegistrarLog("Inserto Proveedor " + txtClave.Text);
                    Conexion.Insertar(linea);

                }
                if (btnModificarPresionado)
                {
                    string linea;
                    DialogResult dialogresult = MessageBox.Show("Realmente desea guardar los cambios", "Mensaje", MessageBoxButtons.YesNo);
                    if (dialogresult == DialogResult.Yes)
                    {
                        linea = "UPDATE provedor SET empresa='" + txtEmpresa.Text + "', telefono='" + mskTelefono.Text + "', calle='" + txtCalle.Text + "', numero='" + txtNumero.Text + "', colonia='" + colonia + "', municipio='" + municipio + "', estado='" + estado + "', estatus='1', clave='" + txtClave.Text + "' WHERE idProvedor= " + straux;
                        Conexion.RegistrarLog("Modifico Proveedor " + txtClave.Text);
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
                        linea = "UPDATE provedor SET  estatus= 0 WHERE idProvedor= " + straux;
                        Conexion.RegistrarLog("Elimino Proveedor " + txtClave.Text);
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (Conexion.ValidarRegistro("SELECT * FROM provedor WHERE estatus = 1"))
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

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            Deshabilitar();
            txtColonia.Visible = false;
            txtEstado.Visible = false;
            txtCiudad.Visible = false;
            label6.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Conexion.ValidarRegistro("SELECT * FROM provedor WHERE estatus = 1"))
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
            frmCPostales post = new frmCPostales();
            post.ShowDialog();
        }
    }
}
