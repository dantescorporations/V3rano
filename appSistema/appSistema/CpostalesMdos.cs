using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace appSistema
{
    class CpostalesMdos
    {

        public void LlenarComboBoxPostales(ComboBox cmbConsulta, string query)
        {
            MySqlConnection cox = CpostalesMdos.ConnectPost();

            try
            {
                DataSet dss = new DataSet();
                MySqlDataAdapter daa = new MySqlDataAdapter(query, cox);
                daa.Fill(dss);

                cmbConsulta.DataSource = dss.Tables[0];
                cmbConsulta.ValueMember = dss.Tables[0].Columns[0].ColumnName;
                cmbConsulta.DisplayMember = dss.Tables[0].Columns[1].ColumnName;

                frmCPostales.dss = dss;
                cox.Close();
            }

            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
                cox.Close();
            }

        }

        public static MySqlConnection ConnectPost()
        {
            MySqlConnection conn = new MySqlConnection("server=127.0.0.1; database=pymes; Uid=root; pwd=;");
            conn.Open();
            return conn;
        }

        public static void LlenarComboBoxPostales2(Label lbl, string query, int val)
        {

            using (MySqlConnection cox = CpostalesMdos.ConnectPost())
            {
                try
                {
                    DataSet ds = new DataSet();
                    MySqlDataAdapter da = new MySqlDataAdapter(query, cox);
                    da.Fill(ds);
                    lbl.Text = ds.Tables[0].Rows[val].ItemArray[0].ToString();
                    frmCPostales.colonia = Convert.ToInt32(ds.Tables[0].Rows[val].ItemArray[2]);
                    frmCPostales.codigopost = Convert.ToInt32(ds.Tables[0].Rows[val].ItemArray[0]);
                    cox.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
