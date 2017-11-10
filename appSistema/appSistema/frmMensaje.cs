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
    public partial class frmMensaje : Form
    {
        string Texto;
        public frmMensaje()
        {
            InitializeComponent();
        }
        public frmMensaje(string texto)
        {

            InitializeComponent();
            Texto = texto;

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMensaje_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label1.Text = Texto;
        }
    }
}
