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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }



       // MySqlConnection con = Conexion.conex();

        MySqlCommand cmd;
       
        MySqlDataReader leer;
       
        //En donde server="nombre del servidor", user id="root" y database="Nombre de la BD a la que nos conectaremos.
        private void btnAceptar_Click(object sender, EventArgs e)
        {

          // string query = "SELECT idEmpleado FROM empleado WHERE usuario='Rene' AND password=MD5('123')";
             string query= ("SELECT idEmpleado FROM empleado WHERE usuario='" + txtUsuario.Text + "' AND password=MD5('" + txtPassword.Text + "')" ); //Realizamos una selecion de la tabla usuari

           // MessageBox.Show(query);
            NuevaContraseña ss = new NuevaContraseña(txtUsuario.Text);

            frmPrincipal pr = new frmPrincipal(/*txtUsuario.Text*/);
            if (Conexion.ObtenerDatos(query) != null) //Si el usuario es correcto nos abrira la otra ventana.
            {
                

                DataRow dr = Conexion.ObtenerDatos(query);
                Conexion.SUsuario = dr[0].ToString();
               // MessageBox.Show(Conexion.SUsuario+"");
                Conexion.RegistrarLog("Inicio de Sesion");

                lblValidar.Text = "Exito al conectar";
                lblValidar.BackColor = Color.Green;
                btnAceptar.Enabled = false;
                if (txtUsuario.Text == txtPassword.Text)
                {

                    this.Hide();
                    ss.ShowDialog();
                    this.Close();
                    Conexion.RegistrarLog("Se abrio Nueva contraseña");
                }
                else
                {
                    this.Hide();
                    pr.ShowDialog();
                    this.Close();
                }
                
            }
              else
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
                lblValidar.Text = "Error al ingresar";
                lblValidar.BackColor = Color.Red;
                lblValidar.ForeColor = Color.White;
              
                
            }

            
        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar == (char)Keys.Enter))
            {
                btnAceptar_Click( sender,  e);
                e.Handled = true;
                return;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
       
           
           
         

        }

    }

