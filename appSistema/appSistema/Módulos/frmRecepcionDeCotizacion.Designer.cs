namespace appSistema.Módulos
{
    partial class frmRecepcionDeCotizacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecepcionDeCotizacion));
            this.lstCotizacion = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.mskFecha = new System.Windows.Forms.MaskedTextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.btnNuevaCot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstCotizacion
            // 
            this.lstCotizacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstCotizacion.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lstCotizacion.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.lstCotizacion.GridLines = true;
            this.lstCotizacion.Location = new System.Drawing.Point(16, 178);
            this.lstCotizacion.Name = "lstCotizacion";
            this.lstCotizacion.Size = new System.Drawing.Size(605, 208);
            this.lstCotizacion.TabIndex = 0;
            this.lstCotizacion.UseCompatibleStateImageBehavior = false;
            this.lstCotizacion.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Número";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Cliente";
            this.columnHeader2.Width = 93;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Producto";
            this.columnHeader3.Width = 106;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Cantidad";
            this.columnHeader4.Width = 67;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Precio";
            this.columnHeader5.Width = 66;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Fecha";
            this.columnHeader6.Width = 89;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label1.Location = new System.Drawing.Point(252, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descripción:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGuardar.Location = new System.Drawing.Point(520, 77);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBorrar.Location = new System.Drawing.Point(520, 106);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 4;
            this.btnBorrar.Text = "Eliminar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Número:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cliente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fecha:";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(65, 11);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(119, 20);
            this.txtN.TabIndex = 12;
            // 
            // mskFecha
            // 
            this.mskFecha.Location = new System.Drawing.Point(336, 43);
            this.mskFecha.Mask = "0000/00/00";
            this.mskFecha.Name = "mskFecha";
            this.mskFecha.Size = new System.Drawing.Size(140, 20);
            this.mskFecha.TabIndex = 14;
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(65, 80);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(119, 20);
            this.txtProducto.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Producto:";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(336, 86);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(140, 67);
            this.txtDesc.TabIndex = 17;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(338, 14);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(138, 20);
            this.txtCantidad.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(278, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Cantidad:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(65, 114);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(119, 20);
            this.txtPrecio.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Precio:";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Descripcion";
            this.columnHeader7.Width = 123;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(63, 43);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(119, 20);
            this.txtCliente.TabIndex = 22;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCliente.Image")));
            this.btnBuscarCliente.Location = new System.Drawing.Point(188, 38);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(32, 32);
            this.btnBuscarCliente.TabIndex = 8;
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarProducto.Image")));
            this.btnBuscarProducto.Location = new System.Drawing.Point(188, 73);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(32, 32);
            this.btnBuscarProducto.TabIndex = 7;
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // btnNuevaCot
            // 
            this.btnNuevaCot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNuevaCot.Location = new System.Drawing.Point(500, 26);
            this.btnNuevaCot.Name = "btnNuevaCot";
            this.btnNuevaCot.Size = new System.Drawing.Size(111, 23);
            this.btnNuevaCot.TabIndex = 23;
            this.btnNuevaCot.Text = "Nueva Cotización";
            this.btnNuevaCot.UseVisualStyleBackColor = false;
            // 
            // frmRecepcionDeCotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(633, 444);
            this.Controls.Add(this.btnNuevaCot);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mskFecha);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.btnBuscarProducto);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstCotizacion);
            this.Name = "frmRecepcionDeCotizacion";
            this.Text = "Recepcion De Cotizacion";
            this.Load += new System.EventHandler(this.frmRecepcionDeCotizacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstCotizacion;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.MaskedTextBox mskFecha;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button btnNuevaCot;
    }
}