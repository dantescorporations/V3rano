using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace appSistema.Módulos
{
    public partial class frmResepcion_Factura : Form
    {   
        string idOrdenC = "";
        public frmResepcion_Factura()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                frmBuscar frm = new frmBuscar();
                frm.Consulta = "SELECT * FROM vista_ordencompra";
                frm.ShowDialog();
                idOrdenC = frm.ID;
                if (idOrdenC.Trim() == "")
                    return;

                DataRow dr = Conexion.ObtenerDatos("SELECT * FROM ordencompra where idOrdenCompra='" + idOrdenC + "'");

                lblOrden.Text = "No. Orden de Compra: " + dr.ItemArray[1].ToString();


                llenar();

            }
            catch (Exception)
            {

                //Log
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                //ELIMINA FACTURA Y LOS CONCEPTOS DE LA FACTURA
                // MessageBox.Show(lstvOrdenCompra.SelectedItems[0].Text);
                Conexion.Eliminar("DELETE FROM detallefacturacompra WHERE idFacturaCompra='" + lstvOrdenCompra.SelectedItems[0].Text + "'");
                Conexion.Eliminar("DELETE FROM `facturacompra` WHERE idFacturaCompra='" + lstvOrdenCompra.SelectedItems[0].Text + "'");
                llenar();
            }
            catch (Exception)
            {


            }
          
        }

        string tasa, folio, serie, fecha, rfcEmisor, rfcReceptor;
        // string[] concepto;

        List<String> concepto = new List<String>();
        List<String> serieproducto = new List<String>();
        List<String> detallecompra = new List<String>();
        List<int> cantidadL = new List<int>();

          public void llenar()
        {
            lstvOrdenCompra.Clear();

            Conexion.LlenarListView(lstvOrdenCompra, "SELECT `IdFacturaCompra`, `Folio`, `Serie`, `Tasa`, `Fecha`, `Proveedor`, `Nombre del Empleado`,`SubTotal`,`IVA`,`Total`  FROM `vista_facturacompracatalogo` WHERE IdOrdenCompra=" + idOrdenC);
            Calcular();
        }
    
        public void Calcular()
        {
            double total=0;

            for (int i = 0; i < lstvOrdenCompra.Items.Count; i++)
            {         
             
               total+=  Double.Parse(lstvOrdenCompra.Items[i].SubItems[9].Text);
            }

            lblTotal.Text = "Total+IVA: $" + total.ToString();
         
        }
        private void CargarXml(string url)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(url);
            XmlTextReader x = new XmlTextReader(url);

            int i = 0;
            while (x.Read())
            {
                if (x.NodeType == XmlNodeType.Element)
                {

                    switch (x.Name)
                    {
                        case "cfdi:Traslado":
                            tasa = x.GetAttribute("TasaOCuota");

                            break;

                        case "cfdi:Comprobante":

                            folio = x.GetAttribute("Folio");
                            serie = x.GetAttribute("Serie");
                            fecha = x.GetAttribute("Fecha");
                            break;

                        case "cfdi:Emisor":

                            // textBox1.Text += "RFC=" + x.GetAttribute("Rfc") + ", Nombre= " + x.GetAttribute("Nombre") + Environment.NewLine;
                            rfcEmisor = x.GetAttribute("Rfc");
                            break;
                        case "cfdi:Receptor":

                            rfcReceptor = x.GetAttribute("Rfc");
                            // textBox1.Text += "RFC=" + x.GetAttribute("Rfc") + ", Nombre= " + x.GetAttribute("Nombre") + Environment.NewLine;
                            break;
                        case "cfdi:Concepto":
                            int cantidad = Int32.Parse(x.GetAttribute("Cantidad"));
                            string descripcion = x.GetAttribute("Descripcion");
                            concepto.Add("," + 1 + ",'" + cantidad + "','" + descripcion + "','" + x.GetAttribute("ValorUnitario") + "'");


                            //se obtiene id del producto si es que existe
                            DataRow idProducto = Conexion.ObtenerDatos("Select idProducto from producto WHERE nombre='" + descripcion + "'");
                            //Ingresa a Almacen Separando cada producto
                            if (idProducto == null)
                            {
                                Conexion.MostrarMensaje("El producto " + descripcion + " no esta registrado en la Base de Datos");
                                return;
                            }

                            /////////////////////////////////////////////////77
                            //String para agregar datos a detalle de compra obteniendo su idDetalleCOmpra
                            cantidadL.Add(cantidad);
                            detallecompra.Add("SELECT idDetalleCompra FROM detalleordencompra WHERE idOrdenCompra=" + idOrdenC + " AND precio=" + x.GetAttribute("ValorUnitario") + " AND  idProducto=" + idProducto.ItemArray[0]);
                            // MessageBox.Show("SELECT idDetalleCompra FROM detalleordencompra WHERE idOrdenCompra=" + idOrdenC + " AND precio=" + x.GetAttribute("ValorUnitario") + " idProducto=" + idProducto.ItemArray[0]);


                            //if (cantidad >= 1)
                            //{  
                            DataRow inv = Conexion.ObtenerDatos("SELECT idInventario FROM `inventario` WHERE idProducto=" + idProducto.ItemArray[0] + " and idAlmacen=0");
                            if (inv == null)
                            {
                                //crea inventario nuevo con almacen recpcion y producto      
                                Conexion.EjecutarConsulta("INSERT INTO inventario( estatus, stock, idProducto, idAlmacen) VALUES ('1','0','" + idProducto.ItemArray[0] + "','0')");
                                //Obtiene idInventario que se acaba de crear 
                                inv = Conexion.ObtenerDatos("SELECT idInventario FROM `inventario` WHERE idProducto=" + idProducto.ItemArray[0] + " and idAlmacen=0");
                            }


                            string fechaH = DateTime.Now.ToString("yyyy-MM-dd h:mm tt");
                            //Los conceptos se separan por productos para agregar a la tabla serieproducto 1 por 1
                            for (int j = 0; j < cantidad; j++)
                            {
                                // string consulta = "INSERT INTO inventario( estatus, stock, idProducto, idAlmacen) VALUES (1,0," + idProductoA + ",0)";

                                //se agrega serie producto
                                serieproducto.Add("INSERT INTO serieproducto( estatus, numeroProducto, fecha, idInventario, idProducto ) VALUES (1,'0','" + fechaH + "','" + inv.ItemArray[0] + "','" + idProducto.ItemArray[0] + "')");
                            }

                            //}
                            //else
                            //{
                            // //   serieproducto.Add();
                            //}






                            //   MessageBox.Show(concepto[i]);
                            i++;
                            //textBox1.Text += "valorUnitario=" + x.GetAttribute("ValorUnitario") + ", Descripcion=" + x.GetAttribute("Descripcion") + ", Unidad=" + x.GetAttribute("Unidad") + ", Cantidad=" + x.GetAttribute("Cantidad") + Environment.NewLine;
                            break;
                    }
                }
            }
             }
        private void VerificarDetalleCompra()
        {
            try
            {


                int x = 0;

                DataRow cantidad;
                DataRow idDetalleCompra;
                if (detallecompra == null)
                {
                    MessageBox.Show("");
                }
                foreach (var item in detallecompra)
                {
                    // se obtiene el id del detalle de compra correspondiente 
                    MessageBox.Show(item.ToString());
                    idDetalleCompra = Conexion.ObtenerDatos(item);
                    // MessageBox.Show(idDetalleCompra.ItemArray[0]+"");
                    cantidad = Conexion.ObtenerDatos("SELECT recibido FROM detalleordencompra where idDetalleCompra=" + idDetalleCompra.ItemArray[0]);
                    int recibido = Int32.Parse(cantidad.ItemArray[0].ToString()) + cantidadL[x];
                    Conexion.EjecutarConsulta("UPDATE detalleordencompra SET recibido = '" + recibido + "' WHERE idDetalleCompra=" + idDetalleCompra.ItemArray[0]);
                    x++;
                }

            }
            catch (Exception)
            {
                DataRow idFactura = Conexion.ObtenerDatos("Select idfacturacompra FROM facturacompra fc INNER JOIN provedor pro on pro.idProvedor=fc.idProveedor Where fc.folio='" + folio + "' and fc.fecha='" + fecha + "' and fc.serie='" + serie + "' and fc.idOrdenCompra='" + idOrdenC + "' and pro.rfc='" + rfcEmisor + "'");
                Conexion.EjecutarConsulta("UPDATE facturacompra SET`verificacion`=1 WHERE idFacturaCompra=" + idFactura[0]);
                Conexion.MostrarMensaje("Puede que ciertos productos no se hallan enlazado a la Orden de Compra");
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {

            if (idOrdenC == "")
            {
                MessageBox.Show("Selecione una Orden de Compra");
                return;
            }

            OpenFileDialog doc = new OpenFileDialog();
            openFileDialog1.Filter = "ARCHIVOS XML |*.xml";
            openFileDialog1.FilterIndex = 1;

            openFileDialog1.Multiselect = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                CargarXml(openFileDialog1.FileName);
            }
        }
    }
}
