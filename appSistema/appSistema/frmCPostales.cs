using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using appSistema.Catalogos;

namespace appSistema
{
    public partial class frmCPostales : Form
    {
        public static DataSet dss;
        public static int colonia;
        public static int codigopost;
        public frmCPostales()
        {
            InitializeComponent();
            string query = "SELECT idEstado, Estado FROM estado WHERE estatus=1";
            CpostalesMdos met = new CpostalesMdos();
            met.LlenarComboBoxPostales(cboEstados, query);
            //Metodos.LlenarComboBox(cboEstados, query);
            cboMunicipios.Enabled = false;
            cboColonias.Enabled = false;
        }

        private void cboEstados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEstados.SelectedIndex == 0)
            {
                string query = "SELECT idMunicipio, Municipio FROM municipio WHERE IdEstado=" + cboEstados.SelectedValue;
                CpostalesMdos met = new CpostalesMdos();
                met.LlenarComboBoxPostales(cboMunicipios, query);
                //frmAlmacen.Estado = Convert.ToInt32(cboEstados.SelectedValue);
                //Metodos.LlenarComboBox(cboMunicipios, query);
                cboMunicipios.Enabled = true;
            }
            else
            {
                if (cboEstados.SelectedIndex != 0)
                {
                    string query = "SELECT idMunicipio, Municipio FROM municipio WHERE IdEstado=" + cboEstados.SelectedValue;
                    //Metodos.LlenarComboBox(cboMunicipios, query);
                    CpostalesMdos met = new CpostalesMdos();
                    met.LlenarComboBoxPostales(cboMunicipios, query);
                    //frmAlmacen.Estado = Convert.ToInt32(cboEstados.SelectedValue);
                    cboMunicipios.Enabled = true;
                }
            }
        }

        private void cboMunicipios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMunicipios.SelectedIndex == 0)
            {
                string query = "SELECT idMunicipal, Colonia FROM colonia WHERE idMunicipal=" + cboMunicipios.SelectedValue + " and Estado = " + cboEstados.SelectedValue;
                //Metodos.LlenarComboBox(cboColonias, query);
                CpostalesMdos met = new CpostalesMdos();
                met.LlenarComboBoxPostales(cboColonias, query);
                //frmAlmacen.Municipio = Convert.ToInt32(cboMunicipios.SelectedValue);
                cboColonias.Enabled = true;
            }
            else
            {
                if (cboMunicipios.SelectedIndex != 0)
                {
                    string query = "SELECT idMunicipal, Colonia FROM colonia WHERE idMunicipal=" + cboMunicipios.SelectedValue + " and Estado = " + cboEstados.SelectedValue;
                    //Metodos.LlenarComboBox(cboColonias, query);
                    CpostalesMdos met = new CpostalesMdos();
                    met.LlenarComboBoxPostales(cboColonias, query);
                    //frmAlmacen.Municipio = Convert.ToInt32(cboMunicipios.SelectedValue);
                    cboColonias.Enabled = true;

                }
            }
        }

        private void cboColonias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboColonias.SelectedIndex == 0)
            {
                string query = "SELECT `Codigo postal`, Colonia, idMunicipio FROM colonia WHERE idMunicipal=" + cboMunicipios.SelectedValue + " and Estado = " + cboEstados.SelectedValue;
                CpostalesMdos.LlenarComboBoxPostales2(lblCP, query, Convert.ToInt32(cboColonias.SelectedIndex));
                cboColonias.Enabled = true;
            }
            else
            {
                if (cboColonias.SelectedIndex != 0)
                {
                    string query = "SELECT `Codigo postal`, Colonia,idMunicipio FROM colonia WHERE idMunicipal=" + cboMunicipios.SelectedValue + " and Estado = " + cboEstados.SelectedValue;
                    CpostalesMdos.LlenarComboBoxPostales2(lblCP, query, Convert.ToInt32(cboColonias.SelectedIndex));
                    cboColonias.Enabled = true;
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            cross();
        }
        public void cross()
        {
            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                string form = Application.OpenForms[i].ToString();
                if (form.Contains("frmAlmacen") != false)
                {
                    frmAlmacen.Estado = Convert.ToInt32(cboEstados.SelectedValue);
                    frmAlmacen.Municipio = Convert.ToInt32(cboMunicipios.SelectedValue);
                    frmAlmacen.colonia = Convert.ToInt32(colonia);
                    frmAlmacen.codigopost = Convert.ToInt32(lblCP.Text);
                    this.Close();
                }
                if (form.Contains("frmCliente") != false)
                {
                    frmCliente.estado = Convert.ToInt32(cboEstados.SelectedValue);
                    frmCliente.municipio = Convert.ToInt32(cboMunicipios.SelectedValue);
                    frmCliente.colonia = Convert.ToInt32(colonia);
                    frmCliente.codigopost = Convert.ToInt32(lblCP.Text);
                    this.Close();
                }
                if (form.Contains("frmUsuarios") != false)
                {
                    frmUsuarios.estado = Convert.ToInt32(cboEstados.SelectedValue);
                    frmUsuarios.municipio = Convert.ToInt32(cboMunicipios.SelectedValue);
                    frmUsuarios.colonia = Convert.ToInt32(colonia);
                    frmUsuarios.codigopost = Convert.ToInt32(lblCP.Text);
                    this.Close();
                }
                if (form.Contains("frmProveedores") != false)
                {
                    frmProveedores.estado = Convert.ToInt32(cboEstados.SelectedValue);
                    frmProveedores.municipio = Convert.ToInt32(cboMunicipios.SelectedValue);
                    frmProveedores.colonia = Convert.ToInt32(colonia);
                    frmProveedores.codigopost = Convert.ToInt32(lblCP.Text);
                    this.Close();
                }
            }
        }
    }
}
