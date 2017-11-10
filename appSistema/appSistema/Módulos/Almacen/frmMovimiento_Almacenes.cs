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
    public partial class frmMovimiento_Almacenes : Form
    {
 
        public frmMovimiento_Almacenes()
        {
            InitializeComponent();
            llenar();
            Conexion.LlenarComboBox(cmbAlmacen, "SELECT * FROM `almacen` WHERE estatus=1");
            btnBuscar.Enabled = false;
        }

        public void llenar()
        {
            lstvProducto.Clear();
            Conexion.LlenarListView(lstvProducto, "Select * from vista_inventario");
            //Conexion.LlenarListView(lstvProducto, "SELECT inv.idInventario, p.nombre, p.codigo, inv.stock, a.nombre FROM inventario inv INNER JOIN producto p ON inv.idProducto=p.idProducto INNER JOIN almacen a on a.idAlmacen=inv.idAlmacen");           
        }
     
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstvProducto.SelectedItems.Count == 0)
                {
                    Conexion.MostrarMensaje("Seleccione el producto que desea mover de Inventario");
                    return;
                }
                frmBuscar frm = new frmBuscar();

                frm.Consulta = "SELECT * FROM vista_serieproducto where idInventario=" + lstvProducto.SelectedItems[0].SubItems[0].Text;
                frm.ShowDialog();

                string idSerieProducto = frm.ID;
                if (idSerieProducto.Trim() == "")
                { }
                else
                {
                    DataRow dr = Conexion.ObtenerDatos("SELECT sp.idProducto, sp.idSerieProducto, inv.idInventario,  a.idAlmacen, a.nombre FROM   inventario inv INNER JOIN  serieproducto sp ON inv.idInventario=sp.idInventario INNER JOIN producto p ON p.idProducto=sp.idProducto INNER JOIN almacen a ON a.idAlmacen=inv.idAlmacen where sp.idSerieProducto=" + idSerieProducto);
                    //VISTA PARA SERIE PRODUCTO SE MUESTRA EN LA PARTE DE ABAJO


                    lblDatosProducto.Text = dr.ItemArray[0].ToString() + " " + dr.ItemArray[1].ToString() + " " + dr.ItemArray[2].ToString() + dr.ItemArray[3].ToString();

                    idProductoA = dr.ItemArray[0].ToString();
                    idSerieProductoA = dr.ItemArray[1].ToString();
                    idInventarioA = dr.ItemArray[2].ToString();
                    idAlmacenA = dr.ItemArray[3].ToString();
                }
                return;

            }
            catch (Exception)
            {


            }
        }
        string idProductoA = "", idSerieProductoA = "", idInventarioA = "", idAlmacenA = "";

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (txtAlmacenActual.Text != cmbAlmacen.Text)
            {

                //Consulta donde se verifica si el idproducto y idalmacen existe
                DataRow dr = Conexion.ObtenerDatos("SELECT idInventario, stock FROM inventario WHERE idProducto=" + idProductoA + " and idAlmacen=" + cmbAlmacen.SelectedValue);
                if (dr != null)
                {
                    // Almacen y producto existen entonces cambia de amacenes
                    CambioAlmacen(dr.ItemArray[0].ToString());
                    //    Conexion.MostrarMensaje("Almacen y producto exiten");
                }
                else
                {
                    // si no exite .....crear  idinventario con idproducto y idalmacen
                    string consulta = "INSERT INTO inventario( estatus, stock, idProducto, idAlmacen) VALUES (1,0," + idProductoA + "," + cmbAlmacen.SelectedValue + ")";
                    Conexion.EjecutarConsulta(consulta);

                    //Se obtiene idInventario que a sido creado
                    dr = Conexion.ObtenerDatos("SELECT idInventario FROM inventario WHERE idProducto=" + idProductoA + " and idAlmacen=" + cmbAlmacen.SelectedValue);
                    //   Conexion.MostrarMensaje("Almacen y producto no existen");

                    CambioAlmacen(dr.ItemArray[0].ToString());
                }
            }
            else
            {
                Conexion.MostrarMensaje("Selecione un Almacen diferente al Actual");
            }
        }
        public void CambioAlmacen(string idInventarioN)
        {
            try
            {

                Conexion.EjecutarConsulta("UPDATE serieproducto SET idInventario=" + idInventarioN + " where idSerieProducto=" + idSerieProductoA);
                //Agrega stock a inventario nuevo
                DataRow st = Conexion.ObtenerDatos("Select COUNT(*) from serieproducto where idInventario=" + idInventarioN);
                Conexion.EjecutarConsulta("UPDATE inventario SET stock=" + st.ItemArray[0] + " WHERE idInventario=" + idInventarioN);
                //RESTA STOCK a inventario antiguo
                st = Conexion.ObtenerDatos("Select COUNT(*) from serieproducto where idInventario=" + idInventarioA);
                Conexion.EjecutarConsulta("UPDATE inventario SET stock=" + st.ItemArray[0] + " WHERE idInventario=" + idInventarioA);
                llenar();
                Conexion.MostrarMensaje("Movimiento de Producto Exitoso");
            }
            catch (Exception)
            {

                throw;
            }


        }

        private void lstvProducto_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            //string strID;
            //if (!(lstvProducto.SelectedItems.Count <= 0))
            //{
            //    strID = (lstvProducto.SelectedItems[0].SubItems[0].Text);
            //    this.Close();
            //}

            if (lstvProducto.SelectedItems.Count > 0)
            {
                btnBuscar.Enabled = true;
            }
            else
            {
                btnBuscar.Enabled = false;
            }

        }
    }
}
