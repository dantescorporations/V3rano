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
    public partial class frmBuscar : Form
    {
        private string consulta;
        public string[] array;
        public string Consulta
        {       
            set { consulta = value; }
        }
        
        public frmBuscar()
        {
            InitializeComponent();
            Conexion.arr = array;
         
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            lstwTabla.Clear();
            string query = "SELECT * FROM vista_empleado WHERE " + cboColumnas.Text + "= '" + txtBuscar.Text + "'";
            Conexion.LlenarListView(lstwTabla, query);
            

        }

        private void frmBuscar_Load(object sender, EventArgs e)
        {

            Conexion.LlenarListView(lstwTabla, consulta);

            List<string> columnas = new List<string>();
            for (int i = 0; i < lstwTabla.Columns.Count; i++)
            {
                columnas.Add(lstwTabla.Columns[i].Text);
            }
            cboColumnas.DataSource = columnas;
        }

        private void lstwTabla_SelectedIndexChanged(object sender, EventArgs e)
        {
            //foreach (ListViewItem lv in lstwTabla.CheckedItems)
            //{
            //    string tmpValues = lv.SubItems[0].Text + ';';
            //    array = tmpValues.Split(';');

            //}
        }

        private void cboColumnas_SelectedIndexChanged(object sender, EventArgs e)
        {

            //int selectedIndex = cboColumnas.SelectedIndex;

            //  lstwTabla.Clear();
           // MessageBox.Show(selectedItem.ToString());
            //"select nombreCompleto from vista_empleado where nombreCompleto= "+txtBuscar.Text+""
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Conexion.arr[0] + "");
        }

        private void lstwTabla_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!(lstwTabla.SelectedItems.Count <= 0))
            {
                strID = (lstwTabla.SelectedItems[0].SubItems[0].Text);
                this.Close();
            }
        }

        string strID;
        public string ID { get { return strID; } }
      
    }
}
