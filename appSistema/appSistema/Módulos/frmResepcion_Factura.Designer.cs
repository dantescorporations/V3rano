namespace appSistema.Módulos
{
    partial class frmResepcion_Factura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResepcion_Factura));
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblOrden = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lstvOrdenCompra = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnImportar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEliminar.Location = new System.Drawing.Point(670, 106);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(97, 32);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar Factura";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblOrden
            // 
            this.lblOrden.AutoSize = true;
            this.lblOrden.Location = new System.Drawing.Point(290, 29);
            this.lblOrden.Name = "lblOrden";
            this.lblOrden.Size = new System.Drawing.Size(113, 13);
            this.lblOrden.TabIndex = 16;
            this.lblOrden.Text = "No. Orden de Compra:";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(558, 405);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(57, 13);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "Total+IVA:";
            // 
            // lstvOrdenCompra
            // 
            this.lstvOrdenCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstvOrdenCompra.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstvOrdenCompra.FullRowSelect = true;
            this.lstvOrdenCompra.GridLines = true;
            this.lstvOrdenCompra.Location = new System.Drawing.Point(31, 68);
            this.lstvOrdenCompra.Name = "lstvOrdenCompra";
            this.lstvOrdenCompra.Size = new System.Drawing.Size(633, 318);
            this.lstvOrdenCompra.TabIndex = 14;
            this.lstvOrdenCompra.UseCompatibleStateImageBehavior = false;
            this.lstvOrdenCompra.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No. Folio";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Proveedor";
            this.columnHeader2.Width = 77;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Fecha";
            this.columnHeader3.Width = 128;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Monto";
            this.columnHeader4.Width = 91;
            // 
            // btnImportar
            // 
            this.btnImportar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnImportar.Location = new System.Drawing.Point(670, 68);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(97, 32);
            this.btnImportar.TabIndex = 13;
            this.btnImportar.Text = "Importar .xml";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Buscar orden de compra";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(31, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(32, 32);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmResepcion_Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(813, 463);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblOrden);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lstvOrdenCompra);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Name = "frmResepcion_Factura";
            this.Text = "frmResepcion_Factura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblOrden;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ListView lstvOrdenCompra;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}