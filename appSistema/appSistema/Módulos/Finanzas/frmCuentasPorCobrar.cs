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
    public partial class frmCuentasPorCobrar : Form
    {
        public frmCuentasPorCobrar()
        {
            InitializeComponent();
        }

        private void frmCuentasPorCobrar_Load(object sender, EventArgs e)
        {
            lstC.Clear();
            lstC.Refresh();
            string query = "SELECT * FROM vista_cuentasporcobrar ";
            Conexion.LlenarListView(lstC, query);
        }
    }
}
