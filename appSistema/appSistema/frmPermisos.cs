using MySql.Data.MySqlClient;
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
    public partial class frmPermisos : Form
    {
        
        public frmPermisos()
        {
            InitializeComponent();

            Conexion.LlenarComboBox(cboUsuario, "select idEmpleado, usuario from empleado where estatus=1 and administrador=0");    
        }
                
        private void btnBuscar_Click(object sender, EventArgs e)
        {
           
        }


        DataRow dr;
        private void cboUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = "";
            string SQL = "SELECT e.idEmpleado, e.nombre, e.a_Paterno, e.a_Materno, e.telefono, e.calle, e.numero, e.colonia, e.municipio, e.estado, d.nombre, p.nombre FROM empleado e inner join departamento d on e.idDepartamento=d.idDepartamento inner join Puesto p on e.idPuesto=p.idPuesto WHERE idEmpleado='" + cboUsuario.SelectedValue + "'";
            Conexion.RegistrarLog("Se modificaron los permios de :"+cboUsuario.Text);
            dr = Conexion.ObtenerDatos(SQL);
            
            if (dr != null)
            {
                label1.Text = "ID: "+dr.ItemArray[0].ToString() +  "\n" +
               "Nombre: " + dr.ItemArray[1].ToString() + " " + dr.ItemArray[2].ToString() + " " + dr.ItemArray[3].ToString()+"\n"+
               "Telefono: "+dr.ItemArray[4].ToString()+"\n"+
               "Direccion: " + dr.ItemArray[5].ToString() + ", #" + dr.ItemArray[6].ToString() + ", " + dr.ItemArray[7].ToString() + ", " + 
               dr.ItemArray[8].ToString() + ", " + dr.ItemArray[9].ToString()+"\n"+
               "Departamento: " + dr.ItemArray[10].ToString()+"\n"+
               "Puesto: " + dr.ItemArray[11].ToString();
            }        
               GenerarPermiso();


        }
        private  void GenerarPermiso()
        {
           

            Conexion.LlenarListBox(ltbPermisosN, "SELECT PU.idPermiso, p.nombrePermiso  from permisousuario PU INNER JOIN permiso P ON P.idPermiso=PU.idPermiso inner join empleado E on e.idEmpleado=PU.idEmpleado WHERE PU.estatus=0 and E.usuario='" + cboUsuario.Text + "'");
            Conexion.LlenarListBox(ltbPermisosV, "SELECT PU.idPermiso, p.nombrePermiso  from permisousuario PU INNER JOIN permiso P ON P.idPermiso=PU.idPermiso inner join empleado E on e.idEmpleado=PU.idEmpleado WHERE PU.estatus=1 and E.usuario='" + cboUsuario.Text + "'");

        }
        private void btnVT_Click(object sender, EventArgs e)
        {
            try
            {
                string Query = "UPDATE permisousuario SET estatus = 1 WHERE estatus = 0 AND idEmpleado=" + cboUsuario.SelectedValue + " ";
             
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                Conexion.EjecutarConsulta(Query);


                GenerarPermiso();
            }
            catch (Exception)
            {

                throw;
            }
         
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (object item in ltbPermisosN.SelectedItems)
                {
                    DataRowView drv = (DataRowView)item;
                    string x = (int)drv[0] + "";

                    string Query = "UPDATE permisousuario SET estatus = 1 WHERE estatus = 0 AND idPermiso =" + x + " AND idEmpleado=" + cboUsuario.SelectedValue + "";
                    Conexion.EjecutarConsulta(Query);

                }

                GenerarPermiso();
            }
            catch (Exception)
            {
                
                throw;
            }
         
        }

        private void btnNT_Click(object sender, EventArgs e)
        {
            try
            {
                string Query = "UPDATE permisousuario SET estatus = 0 WHERE estatus = 1 AND idEmpleado=" + cboUsuario.SelectedValue + " ";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                Conexion.EjecutarConsulta(Query);
              
                GenerarPermiso();
            }
            catch (Exception ex)
            {
               
            } 
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (object item in ltbPermisosV.SelectedItems)
                {
                    DataRowView drv = (DataRowView)item;
                    string x = (int)drv[0] + "";

                    string Query = "UPDATE permisousuario SET estatus = 0 WHERE estatus = 1 AND idPermiso =" + x + " AND idEmpleado=" + cboUsuario.SelectedValue + "";
                    Conexion.EjecutarConsulta(Query);

                }

                GenerarPermiso();
            }
            catch (Exception)
            {
                
                throw;
            }

           

        }

        private void frmPermisos_Load(object sender, EventArgs e)
        {

        }
    }
}
