using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace appSistema
{
 
    public partial class Modificar : Form
    {
       
        string u;
        public Modificar(string user)
        {
            InitializeComponent();
            u = user;
        }
        //MySqlConnection con = Conexion.conex();
        MySqlCommand cmd;
        MySqlDataReader leer;
        
        public void Error()
        {
            lblValidar.Visible = true;
            var t = new Timer();
            t.Interval = 3000;
            t.Tick += (s, f) =>
            {

                lblValidar.Hide();
                t.Stop();
               
            };
            t.Start();

            lblValidar.Text = "Error ";
            lblValidar.BackColor = Color.Red;
            lblValidar.ForeColor = Color.White;
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
           

          string querty = ("SELECT * FROM empleado WHERE usuario='" + u + "'AND password= MD5('" + txtContraseñaA.Text + "') "); //Realizamos una selecion de la tabla usuarios.

            if (Conexion.ObtenerDatos(querty) != null) //Si la contraseña es correcto nos deja cambiarla .
            {
             
          
                if (txtContraseña1.Text == txtContraseña2.Text && txtContraseña2.Text!="")
                    {
                        try
                     {

                         string query = "UPDATE empleado SET password = MD5('" + txtContraseña2.Text + "') WHERE usuario = '" + u + "'";
                         Conexion.ObtenerDatos(query);
                        //Ejecuta la consulta
                        //cmd.ExecuteNonQuery();
                         Conexion.RegistrarLog("Se modifico la contraseña");
                        MessageBox.Show("Contraseña actualizada!!!");

                        limpiar();
                            }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error : " + ex.Message);
                        }
                   
                    }
                    else
                    {
                        Error();
                    }
            }
            else 
            {
                Error();

             
            }

           
           
        }
        public void limpiar ()
        {
            txtContraseña1.Text = "";
            txtContraseña2.Text = "";
            txtContraseñaA.Text = "";
        }

        /*
        private void txtContraseñaA_TextChanged(object sender, EventArgs e)
        {
            
            con.Open(); //Abrimos la conexion creada.
            cmd = new MySqlCommand("SELECT * FROM usuario WHERE usuario='" +u+ "'AND password= MD5('" + txtContraseñaA.Text+ "') ", con); //Realizamos una selecion de la tabla usuarios.
            leer = cmd.ExecuteReader();
            

            if (leer.Read() ) //Si la contraseña es correcto nos deja cambiarla .
            {
                txtContraseñaA.BackColor = Color.Green;
                con.Close();
            }
            else
            {
                txtContraseñaA.BackColor = Color.Red;
                con.Close();
            }

        }
         */
    }
}
