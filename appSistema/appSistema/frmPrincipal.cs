using MySql.Data.MySqlClient;
using appSistema.Catalogos;
using appSistema.Módulos;
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
    public partial class frmPrincipal : Form
    {
        private int childFormNumber = 0;
        MySqlCommand cmd;
        String ust;
        public frmPrincipal(/*string us*/)
        {
            InitializeComponent();
           // ust=us;
          // permisosToolStripMenuItem.Visible = false;
           ValidarAdm();
        }

      private void ValidarAdm()
        {
            DataTable dt = new DataTable();
            string SQL = "SELECT * FROM empleado WHERE usuario='" + ust + "' and administrador=1";
            cmd = new MySqlCommand(SQL);
            Conexion.ObtenerDatos(SQL);
           // MySqlDataAdapter da = new MySqlDataAdapter();
           // da.SelectCommand = cmd;
            
            //dt = new DataTable();
            //da.Fill(dt);
          //Si ews administradors
            if (Conexion.ObtenerDatos(SQL) != null )
            {
          //      permisosToolStripMenuItem.Visible = true;
            }
            else
            {

                string permisos = "SELECT pu.idPermiso, pu.estatus FROM empleado e INNER JOIN permisousuario pu on e.idEmpleado=pu.idEmpleado WHERE  e.usuario='"+ust+"'";
                //Conexion.EjecutarConsulta(permisos);
                //cmd = new MySqlCommand(permisos);
                //cmd.ExecuteNonQuery();
                //da = new MySqlDataAdapter(cmd);
                //DataSet ds = new DataSet();
               // da.Fill(ds, permisos);
                //Si no es administrador  item.SubItems.Add((ds.Tables["Cotizacion"].Rows[i].ItemArray[j].ToString()));


                //if (Conexion.ObtenerDatos(permisos).ItemArray[1].ToString() == "1")
                //{
                //    cambiarContraseñaToolStripMenuItem.Visible=true;
                //}
                //else
                //{
                //    cambiarContraseñaToolStripMenuItem.Visible = false;
                //}

            }
           
            
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        //MySqlConnection con = Conexion.conex();

       
        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
      
                Modificar modif = new Modificar(ust);
                modif.ShowDialog();
               
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void permisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPermisos f = new frmPermisos();
            f.MdiParent = this;
            f.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductos productos = new frmProductos();
            productos.MdiParent = this;
            productos.Show();
        }

        private void obligacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        //CATALOGOS-----------------------------------------------------------------------------------------------

       //USUARIO------------------------------------------------------------------------------------
        private void agregarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios frm = new frmUsuarios();
            frm.MdiParent = this;
            frm.Show();

        }

        private void agregarDepartamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmDepartamento frm = new frmDepartamento();
            frm.MdiParent = this;
            frm.Show();
        }

        private void agregarPuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductos frm = new frmProductos();
            frm.MdiParent = this;
            frm.Show();
        }
        //---------------------------------------------------------------------------------------
        //PRODUCTO
        private void agregarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductos frm = new frmProductos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void agregarTipoDeProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTipo_De_Producto frm = new frmTipo_De_Producto();
            frm.MdiParent = this;
            frm.Show();
        }
        //---------------------------------------------------------------------------------------
        //Cliente
        private void agregarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente frm = new frmCliente();
            frm.MdiParent = this;
            frm.Show();
        }

        private void agregarContacoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmContactoCliente frm = new frmContactoCliente();
            frm.MdiParent = this;
            frm.Show();
        }
        //---------------------------------------------------------------------------------------
        //Provedores
        private void agregarProovedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProveedores frm = new frmProveedores();
            frm.MdiParent = this;
            frm.Show();
        }

        private void agregarContactoProovedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmContactoProvedor frm = new frmContactoProvedor();
            frm.MdiParent = this;
            frm.Show();
        }
        //---------------------------------------------------------------------------------------
        //Provedores
        private void agregarObligacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmObligaciones frm = new frmObligaciones();
            frm.MdiParent = this;
            frm.Show();
        }

        private void agregarTipoDeObligacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTipo_De_Obligacion frm = new frmTipo_De_Obligacion();
            frm.MdiParent = this;
            frm.Show();
        }

        //MODULOS-----------------------------------------------------------------------------------------------

        //VENTAS------------------------------------------------------------------------------------

        private void cotizacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void prefacturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrefacturacion frm = new frmPrefacturacion();
            frm.MdiParent = this;
            frm.Show();
        }
        //ALMACEN------------------------------------------------------------------------------------

        private void entradasEnAlmacenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEntradaAlmacen frm = new frmEntradaAlmacen();
            frm.MdiParent = this;
            frm.Show();
        }

        private void salidasEnAlmacenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void movimientoEntreAlmacenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMovimiento_Almacenes frm = new frmMovimiento_Almacenes();
            frm.MdiParent = this;
            frm.Show();
        }

        private void validacionDeRequisicionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmValidacionReq frm = new frmValidacionReq();
            frm.MdiParent = this;
            frm.Show();
        }
        //ALMACEN------------------------------------------------------------------------------------

        private void solicitudCotizacionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tablaComparativaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTablaComparativa frm = new frmTablaComparativa();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ordenDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
        }

        private void estatusDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstatusCompras frm = new frmEstatusCompras();
            frm.MdiParent = this;
            frm.Show();
        }

        private void permisosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPermisos frm = new frmPermisos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void bancosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void cuentasPorCobrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarGastoToolStripMenuItem_Click(object sender, EventArgs e)
        {

           frmGastos frm = new frmGastos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void agregarTipoDeGastoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmTipoGasto frm = new frmTipoGasto();
            frm.MdiParent = this;
            frm.Show();
        }

        private void agregarAlmacénToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmAlmacen frm = new frmAlmacen();
            frm.MdiParent = this;
            frm.Show();
        }

        private void pagoDeVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPagodeVenta frm = new frmPagodeVenta();
            frm.MdiParent = this;
            frm.Show();
        }

       

     

          
        }

        
    }

