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
    public partial class frmContactoProvedor : Form
    {
        public frmContactoProvedor()
        {
            InitializeComponent();
        }
        bool btnInsertarPresionado = false;
        bool btnModificarPresionado = false;
        bool btnEliminarPresionado = false;
        string straux;
        public void Habilitar()
        {
            txtClave.Enabled = true;
            txtNombre.Enabled = true;
            maskTelefono.Enabled = true;
            mskExtension.Enabled = true;
            txtAP.Enabled = true;
            txtAM.Enabled = true;
            cboEmpresa.Enabled = true;
            cboTipoContacto.Enabled = true;
        }
        public void Deshabilitar()
        {
            txtClave.Enabled = false;
            txtNombre.Enabled = false;
            maskTelefono.Enabled = false;
            mskExtension.Enabled = false;
            txtAP.Enabled = false;
            txtAM.Enabled = false;
            cboEmpresa.Enabled = false;
            cboTipoContacto.Enabled = false;
        }

        public void Limpiar()
        {
            txtClave.Text = "";
            txtNombre.Text = "";
            maskTelefono.Text = "";
            mskExtension.Text = "";
            txtAP.Text = "";
            txtAM.Text = "";
            cboEmpresa.Text = "";
            cboTipoContacto.Text = "";
        }
        private void frmContactoProvedor_Load(object sender, EventArgs e)
        {
            Deshabilitar();
            try
            {
                string query = "SELECT idTipoContactoProveedor, descripcion FROM tipocontactoproveedor WHERE estatus=1";
                string query2 = "SELECT idProvedor, empresa FROM provedor WHERE estatus=1";

                Conexion.LlenarComboBox(cboTipoContacto, query);
                Conexion.LlenarComboBox(cboEmpresa, query2);


            }
            catch (Exception)
            {

                //throw;
            }
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

                    linea = "INSERT INTO contactoproveedor(nombre, a_Paterno, a_Materno, telefono, extencion, estatus, idProveedor, idTipoContactoProveedor,idContactoP) VALUES ('" + txtNombre.Text + "', '" + txtAP.Text + "','" + txtAM.Text + "', '" + maskTelefono.Text + "', '" + mskExtension.Text + "',1, '" + cboEmpresa.SelectedValue + "', '" + cboTipoContacto.SelectedValue + "', '" + txtClave.Text + "')";
                    Conexion.RegistrarLog("Inserto contacto proveedor " + txtClave.Text);
                    Conexion.Insertar(linea);
                }
                if (btnModificarPresionado)
                {
                    string linea;

                    linea = "UPDATE contactoproveedor SET nombre='" + txtNombre.Text + "', a_Paterno='" + txtAP.Text + "', a_Materno='" + txtAM.Text + "', telefono='" + maskTelefono.Text + "', extencion='" + mskExtension.Text + "', estatus='1', idCliente='" + cboEmpresa.ValueMember + "', idTipoContactoCliente='" + cboEmpresa.ValueMember + "', clave='" + txtClave.Text + "' WHERE idContactoP= " + straux;
                    Conexion.RegistrarLog("Modifico contacto proveedor " + txtClave.Text);
                    Conexion.Insertar(linea);
                }
                if (btnEliminarPresionado)
                {
                    string linea;

                    linea = "UPDATE contactoproveedor SET  estatus= 0 WHERE idContactoProveedor= " + straux;
                    Conexion.RegistrarLog("Elimino contacto proveedor " + txtClave.Text);
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
            if (Conexion.ValidarRegistro("SELECT * FROM contactoproveedor WHERE estatus = 1"))
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

        private void btnBuscarPlan_Click(object sender, EventArgs e)
        {
            try
            {
                frmBuscar frm = new frmBuscar();
                frm.Consulta = "SELECT * FROM vista_contactoproveedor";
                frm.ShowDialog();
                straux = frm.ID;
                if (straux.Trim() == "")
                    return;

                DataRow dr = Conexion.ObtenerDatos("SELECT * FROM contactoproveedor where idContactoP = '" + straux + "'");

                txtClave.Text = dr.ItemArray[9].ToString();
                txtNombre.Text = dr.ItemArray[1].ToString();
                txtAP.Text = dr.ItemArray[2].ToString();
                txtAM.Text = dr.ItemArray[3].ToString();
                maskTelefono.Text = dr.ItemArray[4].ToString();
                mskExtension.Text = dr.ItemArray[5].ToString();
                cboEmpresa.ValueMember = dr.ItemArray[7].ToString();
                cboTipoContacto.ValueMember = dr.ItemArray[8].ToString();
          
            }
            catch (Exception)
            {

                return;
            }

            //MessageBox.Show(straux);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Conexion.ValidarRegistro("SELECT * FROM contactoproveedor WHERE estatus = 1"))
            {
                btnEliminarPresionado = true;

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
