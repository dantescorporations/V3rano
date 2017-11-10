using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSistema.Módulos
{
    public partial class frmCuentasPorPagar : Form
    {
        private string consulta;
        public string[] array;
        public frmCuentasPorPagar()
        {
            InitializeComponent();
        }

        private void frmCuentasPorPagar_Load(object sender, EventArgs e)
        {

            lstC.Clear();
            lstC.Refresh();
            string query = "SELECT * FROM vistas_cuentasporpagar ";
            Conexion.LlenarListView(lstC, query);
        }
    }
}
