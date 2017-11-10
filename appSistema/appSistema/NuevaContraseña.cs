using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSistema
{
    public partial class NuevaContraseña : Form
    {
        string nombre;
        public NuevaContraseña(string x)
        {
            InitializeComponent();
            nombre = x;
        }
        

        public void obtener(TextBox txt)
        {
           
        }

        //MySqlConnection con = Conexion.conex();
        //En donde server="nombre del servidor", user id="root" y database="Nombre de la BD a la que nos conectaremos.
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            
            if (txtContraseña.Text == "" || txtRContraseña.Text == "")
            {
                MessageBox.Show("uno de los campos esta vacio ");
            }

            else if (txtContraseña.Text == txtRContraseña.Text)
            {
              //Abrimos la conexion creada.
                try
                {

                    string query = "UPDATE empleado SET password = md5('" + txtRContraseña.Text + "') WHERE usuario = '"+nombre+"'";
                    Conexion.EjecutarConsulta(query);
                    Conexion.RegistrarLog("Se actualizo contrseña");
                    MessageBox.Show("Contraseña actualizada!!!");
                    limpir();
                    this.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error : " + ex.Message);
                }
            }

            else
            {
                MessageBox.Show("las contraseñas no coinsiden");
            }
           
          
        }

        public void limpir()
        {
            txtContraseña.Text = "";
            txtRContraseña.Text = "";
        }


    }
}
