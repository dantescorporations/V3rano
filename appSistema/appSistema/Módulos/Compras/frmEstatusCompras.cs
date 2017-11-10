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
    public partial class frmEstatusCompras : Form
    {
        public frmEstatusCompras()
        {
            InitializeComponent();
            l();
        }
        private void l()
        {
            lstvConcentrado.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lstvConcentrado.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btnRastrear_Click(object sender, EventArgs e)
        {

        }
    }
}
