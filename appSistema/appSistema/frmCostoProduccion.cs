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
    public partial class frmCostoProduccion : Form
    {
        public frmCostoProduccion()
        {
            InitializeComponent();
        }

        private void Requizicion_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            frmBuscar f = new frmBuscar();
            f.Consulta = "LA CONSULTA";
            f.ShowDialog();
        }

        private void lstvRequisicion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
