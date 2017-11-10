namespace appSistema
{
    partial class frmMovimiento_Almacenes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMovimiento_Almacenes));
            this.lblDatosProducto = new System.Windows.Forms.Label();
            this.cmbAlmacen = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtAlmacenActual = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstvProducto = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDatosProducto
            // 
            this.lblDatosProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDatosProducto.AutoSize = true;
            this.lblDatosProducto.Location = new System.Drawing.Point(158, 392);
            this.lblDatosProducto.Name = "lblDatosProducto";
            this.lblDatosProducto.Size = new System.Drawing.Size(98, 13);
            this.lblDatosProducto.TabIndex = 23;
            this.lblDatosProducto.Text = "Datos del Producto";
            // 
            // cmbAlmacen
            // 
            this.cmbAlmacen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlmacen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbAlmacen.FormattingEnabled = true;
            this.cmbAlmacen.Location = new System.Drawing.Point(345, 360);
            this.cmbAlmacen.Name = "cmbAlmacen";
            this.cmbAlmacen.Size = new System.Drawing.Size(121, 21);
            this.cmbAlmacen.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Almacen Actual";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAceptar.Location = new System.Drawing.Point(48, 384);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 29);
            this.btnAceptar.TabIndex = 20;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtAlmacenActual
            // 
            this.txtAlmacenActual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtAlmacenActual.Enabled = false;
            this.txtAlmacenActual.Location = new System.Drawing.Point(161, 360);
            this.txtAlmacenActual.Name = "txtAlmacenActual";
            this.txtAlmacenActual.Size = new System.Drawing.Size(121, 20);
            this.txtAlmacenActual.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Almacén nuevo";
            // 
            // lstvProducto
            // 
            this.lstvProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstvProducto.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lstvProducto.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lstvProducto.FullRowSelect = true;
            this.lstvProducto.GridLines = true;
            this.lstvProducto.HideSelection = false;
            this.lstvProducto.Location = new System.Drawing.Point(29, 53);
            this.lstvProducto.Name = "lstvProducto";
            this.lstvProducto.Size = new System.Drawing.Size(643, 283);
            this.lstvProducto.TabIndex = 17;
            this.lstvProducto.UseCompatibleStateImageBehavior = false;
            this.lstvProducto.View = System.Windows.Forms.View.Details;
            this.lstvProducto.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstvProducto_ItemSelectionChanged);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "#Producto";
            this.columnHeader6.Width = 111;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Nombre";
            this.columnHeader7.Width = 91;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Stock";
            this.columnHeader8.Width = 78;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Almacen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Buscar producto";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(29, 6);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(32, 32);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmMovimiento_Almacenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(706, 425);
            this.Controls.Add(this.lblDatosProducto);
            this.Controls.Add(this.cmbAlmacen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtAlmacenActual);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstvProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Name = "frmMovimiento_Almacenes";
            this.Text = "Movimiento Entre Almacenes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDatosProducto;
        private System.Windows.Forms.ComboBox cmbAlmacen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtAlmacenActual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lstvProducto;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;

    }
}