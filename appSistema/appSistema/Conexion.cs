using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using appSistema.Módulos;

namespace appSistema
{
    static class Conexion
    {
        private static MySqlConnection con = new MySqlConnection("server=127.0.0.1; database=pymes; Uid=root; pwd=;");
        public static string[] arr;

        private static  void Conectar()
        {
            try
            {
                con.Close();
                con.Open();
            }
            catch (Exception)
            {
                
              
            }
         
        }

        //---------------------- Usuario Global Loguado
        public static string SUsuario;


        //---Registra los eventos del usuario 
        public static void RegistrarLog(string descripcion)
        {
            //CAMBIAR VALUE POR SUsuario
            string query = "INSERT INTO log ( idEmpleado, fecha, descripcion) VALUES ( '"+SUsuario+"', '" + DateTime.Now + "', '" + descripcion + "')";
            Conectar();
            try
            {

                Conectar();
                MySqlCommand sqlc = new MySqlCommand(query, con);
                sqlc.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se esta registrando Las Actividades en el LOG");
                MessageBox.Show(query);
            }
            con.Close();

        }
        public static void LlenarListBox(ListBox lstConsulta, string query)
        {
            Conectar();
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(query,con);
         
            da.Fill(ds);

       
            lstConsulta.DataSource = ds.Tables[0];
            lstConsulta.DisplayMember = "nombrePermiso";
            lstConsulta.ValueMember = "idPermiso";

            con.Close();
        }

        public static void LlenarListView(ListView lstConsulta, string query)
        {
            try
            {
                Conectar();
                //MySqlCommand q = new MySqlCommand(query, con);
                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                //da.SelectCommand = q;
                DataSet ds = new DataSet();
                da.Fill(ds);

                for (int i = 0; i < ds.Tables[0].Columns.Count; i++)
                {
                    lstConsulta.Columns.Add(ds.Tables[0].Columns[i].ColumnName);
                }
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ListViewItem item = new ListViewItem(row[0].ToString());
                    for (int j = 1; j < ds.Tables[0].Columns.Count; j++)
                    {
                        item.SubItems.Add(row[j].ToString());
                    }
                    lstConsulta.Items.Add(item);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+"");
            }
        }


        //public static void LlenarCombo(ComboBox cbo, ListView lstwTabla)
        //{
        //    for (int i = 0; i < lstwTabla.Columns.Count; i++)
        //    {
        //        cbo.DataSource = lstwTabla.ToString();
              
        //        cbo.DisplayMember = lstwTabla.Columns[i].Name;
        //    }
        //}


        public static void LlenarComboBox(ComboBox cmbConsulta, string query)
        {
            Conectar();
            try
            {
                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                da.Fill(ds);

                cmbConsulta.DataSource = ds.Tables[0];
                cmbConsulta.ValueMember =ds.Tables[0].Columns[0].ColumnName;
                cmbConsulta.DisplayMember = ds.Tables[0].Columns[1].ColumnName; 
             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 


            con.Close();
        }

        public static void EjecutarConsulta(string query)
        {
            try
            {
                //string Query = "UPDATE permisousuario SET estatus = 1 WHERE estatus = 0 AND idUsuario=" + dt.Rows[0].ItemArray[0].ToString() + " ";
                //This is  MySqlConnection here i have created the object and pass my connection string.  

                MySqlCommand MyCommand2 = new MySqlCommand(query, con);

                MySqlDataReader MyReader2;
                Conectar();
                MyReader2 = MyCommand2.ExecuteReader();

                con.Close();//Connection closed here  
                //GenerarPermiso();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        public static DataRow ObtenerDatos(string query)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(query);
                cmd.Connection = con;
                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    return dt.Rows[0];
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
             
            }
      
        }

        public static bool ValidarRegistro(string query)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(query);
                cmd.Connection = con;
                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                 
                    return false;
                }
            }
            catch (Exception)
            {
                return false;

            }

        }



        public static void Insertar(string query)
        {

            try
            {
                Conectar();
                MySqlCommand sqlc = new MySqlCommand(query,con);
                sqlc.ExecuteNonQuery();
                MessageBox.Show("Hecho");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
          
        }
     

        public static void MostrarMensaje(string texto)
        {
  
            frmMensaje x = new frmMensaje(texto);
     
            x.ShowDialog();
        }
        public static void Modificar(string query)
        {

            try
            {
                Conectar();
                MySqlCommand sqlc = new MySqlCommand(query, con);
                sqlc.ExecuteNonQuery();
                MessageBox.Show("Se modificó correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

        }
        public static void Eliminar(string query)
        {

            try
            {
                Conectar();
                MySqlCommand sqlc = new MySqlCommand(query, con);
                sqlc.ExecuteNonQuery();
                MessageBox.Show("Se eliminó correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

        }


    }

}
