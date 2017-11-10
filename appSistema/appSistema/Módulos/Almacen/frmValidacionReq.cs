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
    public partial class frmValidacionReq : Form
    {
        public frmValidacionReq()
        {
            InitializeComponent();
        }

        private void frmValidacionReq_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM vista_requisicionno";
            Conexion.LlenarListView(lstvReqNA, query);

            string query2 = "SELECT * FROM vista_requisicion";
            Conexion.LlenarListView(lstvReqA, query2);
        }

        private void lstvReqNA_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!(lstvReqNA.SelectedItems.Count <= 0))
            {
                string strID = (lstvReqNA.SelectedItems[0].SubItems[0].Text);
                string query3 = "UPDATE requisicion SET estatus='1' where NoRequisicion= " + strID + "";
                Conexion.Modificar(query3);
            }
        }
    }
}
