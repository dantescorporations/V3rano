namespace appSistema
{
    partial class frmSolicitudCot
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSolicitudCot));
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lstvCotizacion = new System.Windows.Forms.ListView();
            this.Req = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.producto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contactoprov = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.solicitante = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.departamento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 84;
            this.label1.Text = "Buscar proveedor:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(117, 16);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(32, 32);
            this.btnBuscar.TabIndex = 83;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(155, 23);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(100, 20);
            this.txtProveedor.TabIndex = 82;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnviar.Location = new System.Drawing.Point(694, 304);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(108, 44);
            this.btnEnviar.TabIndex = 81;
            this.btnEnviar.Text = "Enviar Solicitud";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lstvCotizacion
            // 
            this.lstvCotizacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstvCotizacion.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Req,
            this.producto,
            this.cantidad,
            this.contactoprov,
            this.solicitante,
            this.departamento,
            this.fecha});
            this.lstvCotizacion.FullRowSelect = true;
            this.lstvCotizacion.GridLines = true;
            this.lstvCotizacion.Location = new System.Drawing.Point(8, 61);
            this.lstvCotizacion.Name = "lstvCotizacion";
            this.lstvCotizacion.Size = new System.Drawing.Size(794, 224);
            this.lstvCotizacion.TabIndex = 80;
            this.lstvCotizacion.UseCompatibleStateImageBehavior = false;
            this.lstvCotizacion.View = System.Windows.Forms.View.Details;
            // 
            // Req
            // 
            this.Req.Text = "No. Requisición";
            this.Req.Width = 89;
            // 
            // producto
            // 
            this.producto.Text = "Producto";
            this.producto.Width = 174;
            // 
            // cantidad
            // 
            this.cantidad.Text = "Cantidad";
            this.cantidad.Width = 67;
            // 
            // contactoprov
            // 
            this.contactoprov.DisplayIndex = 4;
            this.contactoprov.Text = "Contacto Proveedor";
            this.contactoprov.Width = 115;
            // 
            // solicitante
            // 
            this.solicitante.DisplayIndex = 5;
            this.solicitante.Text = "Solicitante";
            this.solicitante.Width = 133;
            // 
            // departamento
            // 
            this.departamento.DisplayIndex = 6;
            this.departamento.Text = "Departamento";
            this.departamento.Width = 137;
            // 
            // fecha
            // 
            this.fecha.DisplayIndex = 3;
            this.fecha.Text = "Fecha";
            this.fecha.Width = 78;
            // 
            // frmSolicitudCot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(818, 364);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtProveedor);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.lstvCotizacion);
            this.Name = "frmSolicitudCot";
            this.Text = "SOLICITUD COTIZACION";
            this.Load += new System.EventHandler(this.SolicitudCot_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.ListView lstvCotizacion;
        private System.Windows.Forms.ColumnHeader Req;
        private System.Windows.Forms.ColumnHeader producto;
        private System.Windows.Forms.ColumnHeader cantidad;
        private System.Windows.Forms.ColumnHeader contactoprov;
        private System.Windows.Forms.ColumnHeader solicitante;
        private System.Windows.Forms.ColumnHeader departamento;
        private System.Windows.Forms.ColumnHeader fecha;

    }
}