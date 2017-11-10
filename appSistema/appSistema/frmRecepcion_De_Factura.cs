using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace appSistema
{
    public partial class frmRecepcion_De_Factura : Form
    {
        public frmRecepcion_De_Factura()
        {
            InitializeComponent();
        }

        public void CargarXml(string x)
        {

        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            OpenFileDialog doc = new OpenFileDialog();
            openFileDialog1.Filter = "ARCHIVOS XML |*.xml";
            openFileDialog1.FilterIndex = 1;

            openFileDialog1.Multiselect = true;

            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                CargarXml(openFileDialog1.FileName);
            }
        }
    }
}
