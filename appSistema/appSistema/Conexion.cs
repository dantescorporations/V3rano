using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using appSistema.Módulos;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Excel = Microsoft.Office.Interop.Excel;


namespace appSistema
{
    static class Conexion
    {
        public static MySqlConnection con = new MySqlConnection("server=127.0.0.1; database=pymes; Uid=root; pwd=;");
        public static string[] arr;

        private static void Conectar()
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
            string query = "INSERT INTO log ( idEmpleado, fecha, descripcion) VALUES ( '" + SUsuario + "', '" + DateTime.Now + "', '" + descripcion + "')";
            Conectar();
            try
            {

                Conectar();
                MySqlCommand sqlc = new MySqlCommand(query, con);
                sqlc.ExecuteNonQuery();

            }
            catch (Exception)
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
            MySqlDataAdapter da = new MySqlDataAdapter(query, con);

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
                lstConsulta.Clear();
                Conectar();
                //MySqlCommand q = new MySqlCommand(query, con);
                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                //da.SelectCommand = q;
                //DataSet ds = new DataSet();
                DataTable ds = new DataTable();
                da.Fill(ds);

                for (int i = 0; i < ds.Columns.Count; i++)
                {
                    lstConsulta.Columns.Add(ds.Columns[i].ColumnName);
                }
                foreach (DataRow row in ds.Rows)
                {
                    ListViewItem item = new ListViewItem(row[0].ToString());
                    for (int j = 1; j < ds.Columns.Count; j++)
                    {
                        item.SubItems.Add(row[j].ToString());
                    }
                    lstConsulta.Items.Add(item);
                }
                lstConsulta.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "");
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
                cmbConsulta.ValueMember = ds.Tables[0].Columns[0].ColumnName;
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
                MySqlCommand sqlc = new MySqlCommand(query, con);
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
        public static bool ValidarEstatus(string query)
        {
            if (Conexion.ValidarRegistro(query))
            {
                return true;
            }

            return false;
        }
        public static void ExportToExcel(this DataTable tbl, string excelFilePath = null)
        {
            try
            {
                if (tbl == null || tbl.Columns.Count == 0)
                    throw new Exception("ExportToExcel: Null or empty input table!\n");

                // load excel, and create a new workbook
                var excelApp = new Excel.Application();
                excelApp.Workbooks.Add();

                // single worksheet
                Excel._Worksheet workSheet = excelApp.ActiveSheet;

                // column headings
                for (var i = 0; i < tbl.Columns.Count; i++)
                {
                    workSheet.Cells[1, i + 1] = tbl.Columns[i].ColumnName;
                }

                // rows
                for (var i = 0; i < tbl.Rows.Count; i++)
                {
                    // to do: format datetime values before printing
                    for (var j = 0; j < tbl.Columns.Count; j++)
                    {
                        workSheet.Cells[i + 2, j + 1] = tbl.Rows[i][j];
                    }
                }

                // check file path
                if (!string.IsNullOrEmpty(excelFilePath))
                {
                    try
                    {
                        workSheet.SaveAs(excelFilePath);
                        excelApp.Quit();
                        MessageBox.Show("Archivo Exportado Con Exito!");
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("ExportToExcel: Excel file could not be saved! Check filepath.\n"
                                            + ex.Message);
                    }
                }
                else
                { // no file path is given
                    excelApp.Visible = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("ExportToExcel: \n" + ex.Message);
            }
        }
        public static void ExportToPdf(this DataTable dt, string filepath = null)
        {
            Document document = new Document();
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filepath, FileMode.Create));
            document.Open();

            PdfPTable table = new PdfPTable(dt.Columns.Count);
            table.WidthPercentage = 100;

            //Set columns names in the pdf file
            for (int k = 0; k < dt.Columns.Count; k++)
            {
                PdfPCell cell = new PdfPCell(new Phrase(dt.Columns[k].ColumnName));
                cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                cell.VerticalAlignment = PdfPCell.ALIGN_CENTER;
                cell.BackgroundColor = new iTextSharp.text.BaseColor(51, 102, 102);

                table.AddCell(cell);
            }

            //Add values of DataTable in pdf file
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(dt.Rows[i][j].ToString()));

                    //Align the cell in the center
                    cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                    cell.VerticalAlignment = PdfPCell.ALIGN_CENTER;

                    table.AddCell(cell);
                }
            }

            document.Add(table);
            document.Close();

            System.Diagnostics.Process.Start(filepath);

        }
    }
}
