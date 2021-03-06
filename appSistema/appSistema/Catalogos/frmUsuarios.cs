﻿using System;
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
            txtRFC.Text = "";
            txtNombre.Text = "";
            txtUsuario.Text = "";
            txtContraseña.Text = "";
            txtAP.Text = "";
            txtAM.Text = "";
            txtEstado.Text = "";
            txtTelefono.Text = "";
            txtCalle.Text = "";
            msktxtNumero.Text = "";
            txtColonia.Text = "";
            txtCiudad.Text = "";
            cboPuesto.Text = "";
            cboDepartamento.Text = "";

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
                txtEstado.Text = dr.ItemArray[9].ToString();
                txtTelefono.Text = dr.ItemArray[4].ToString();
                txtCalle.Text = dr.ItemArray[5].ToString();
                msktxtNumero.Text = dr.ItemArray[6].ToString();
                txtColonia.Text = dr.ItemArray[7].ToString();
                txtCiudad.Text = dr.ItemArray[8].ToString();
                cboPuesto.SelectedValue = dr.ItemArray[15].ToString();
                cboDepartamento.SelectedValue = dr.ItemArray[16].ToString();
            }
            catch (Exception)
            {

                return;
            }

     
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
                    linea = "INSERT INTO empleado (nombre,a_Paterno, a_Materno, telefono, calle, numero, colonia, municipio, estado, rfc, usuario, password, administrador, estatus, idPuesto, idDepartamento) VALUES ('" + txtNombre.Text + "', '" + txtAP.Text + "','" + txtAM.Text + "', '" + txtTelefono.Text + "', '" + txtCalle.Text + "', '" + msktxtNumero.Text + "', '" + txtColonia.Text + "', '" + txtCiudad.Text + "', '" + txtEstado.Text + "', '" + txtRFC.Text + "', '" + txtUsuario.Text + "', '" + txtContraseña.Text + "', '" + cboAdministrador.SelectedValue + "','1', '" + cboPuesto.SelectedValue + "',' " + cboDepartamento.SelectedValue + "')";
                    Conexion.RegistrarLog("Inserto usuario con el RFC " + txtRFC.Text);
                    Conexion.Insertar(linea);

                }
                if (btnModificarPresionado)
                {
                    string linea;

                    linea = "UPDATE empleado SET nombre='" + txtNombre.Text + "', a_Paterno='" + txtAP.Text + "', a_Materno='" + txtAM.Text + "', telefono='" + txtTelefono.Text + "', calle='" + txtCalle.Text + "', numero='" + msktxtNumero.Text + "', colonia='" + txtColonia.Text + "', municipio='" + txtCiudad.Text + "', estado='" + txtEstado.Text + "', rfc='" + txtRFC.Text + "', usuario='" + txtUsuario.Text + "', idPuesto='" + cboPuesto.SelectedValue + "', idDepartamento='" + cboDepartamento.SelectedValue + "' WHERE idEmpleado= " + straux;
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
        
                    linea = "INSERT INTO empleado (nombre, a_Paterno, a_Materno, telefono, calle, numero, colonia, municipio, estado, rfc, usuario, password, administrador, estatus, idPuesto, idDepartamento) VALUES ('" + txtNombre.Text + "', '" + txtAP.Text + "','" + txtAM.Text + "', '" + txtTelefono.Text + "', '" + txtCalle.Text + "', '" + msktxtNumero.Text + "', '" + txtColonia.Text + "', '" + txtCiudad.Text + "', '" + txtEstado.Text + "', '" + txtRFC.Text + "', '" + txtUsuario.Text + "', MD5('" + txtContraseña.Text + "'), '" + cboAdministrador.SelectedValue + "','1', '" + cboPuesto.SelectedValue + "',' " + cboDepartamento.SelectedValue + "')";
                    Conexion.RegistrarLog("Inserto usuario con el RFC " + txtRFC.Text);
                    Conexion.Insertar(linea);
                    BtnCancelar_Click(sender, e);

                }
                if (btnModificarPresionado)
                {

                    if ((txtContraseña.Text == "") || (txtUsuario.Text == "") || (txtNombre.Text == "") || (txtAM.Text == "") || (txtAP.Text == "") || (txtRFC.Text == "") || (txtCalle.Text == "") || (msktxtNumero.Text == ""))
                    {
                        MessageBox.Show("Faltan Llenar campos");
                        return;
                    }

                    string linea;

                    linea = "UPDATE empleado SET nombre='" + txtNombre.Text + "', a_Paterno='" + txtAP.Text + "', a_Materno='" + txtAM.Text + "', telefono='" + txtTelefono.Text + "', calle='" + txtCalle.Text + "', numero='" + msktxtNumero.Text + "', colonia='" + txtColonia.Text + "', municipio='" + txtCiudad.Text + "', estado='" + txtEstado.Text + "', rfc='" + txtRFC.Text + "', usuario='" + txtUsuario.Text + "', password='" + txtContraseña.Text + "', administrador='" + cboAdministrador.SelectedValue + "', estatus='1', idPuesto='" + cboPuesto.SelectedValue + "', idDepartamento='" + cboDepartamento.SelectedValue + "' WHERE idEmpleado= " + straux;
                    Conexion.RegistrarLog("Modifico usuario con el RFC " + txtRFC.Text);
                    Conexion.Insertar(linea);
                    BtnCancelar_Click(sender, e);
                }
                if (btnEliminarPresionado)
                {
                 
                    
                     
                        string linea;
                       DialogResult dialogresult= MessageBox.Show("Realmente desea Eliminar El Empleado Seleccionado","Mensaje",MessageBoxButtons.YesNo);
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
    }
}
