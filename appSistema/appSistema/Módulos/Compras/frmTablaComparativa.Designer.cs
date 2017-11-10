namespace appSistema
{
    partial class frmTablaComparativa
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
            this.lstTblacomparativa = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.lstAprobados = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cboProveedor = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnBuscartodos = new System.Windows.Forms.Button();
            this.btnEliminarAprobados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstTblacomparativa
            // 
            this.lstTblacomparativa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstTblacomparativa.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.lstTblacomparativa.FullRowSelect = true;
            this.lstTblacomparativa.GridLines = true;
            this.lstTblacomparativa.Location = new System.Drawing.Point(12, 31);
            this.lstTblacomparativa.Name = "lstTblacomparativa";
            this.lstTblacomparativa.Size = new System.Drawing.Size(875, 235);
            this.lstTblacomparativa.TabIndex = 27;
            this.lstTblacomparativa.UseCompatibleStateImageBehavior = false;
            this.lstTblacomparativa.View = System.Windows.Forms.View.Details;
            this.lstTblacomparativa.DoubleClick += new System.EventHandler(this.lstTblacomparativa_DoubleClick);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label5.Location = new System.Drawing.Point(914, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Proveedor a elegir:";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button3.Location = new System.Drawing.Point(12, 689);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 25);
            this.button3.TabIndex = 34;
            this.button3.Text = "Emitir Orden de Compra";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // lstAprobados
            // 
            this.lstAprobados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstAprobados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lstAprobados.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.lstAprobados.GridLines = true;
            this.lstAprobados.Location = new System.Drawing.Point(12, 308);
            this.lstAprobados.Name = "lstAprobados";
            this.lstAprobados.Size = new System.Drawing.Size(1116, 235);
            this.lstAprobados.TabIndex = 36;
            this.lstAprobados.UseCompatibleStateImageBehavior = false;
            this.lstAprobados.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Aprobados";
            this.columnHeader1.Width = 863;
            // 
            // cboProveedor
            // 
            this.cboProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProveedor.FormattingEnabled = true;
            this.cboProveedor.Location = new System.Drawing.Point(903, 83);
            this.cboProveedor.Name = "cboProveedor";
            this.cboProveedor.Size = new System.Drawing.Size(143, 21);
            this.cboProveedor.TabIndex = 104;
            this.cboProveedor.SelectedIndexChanged += new System.EventHandler(this.cboProveedor_SelectedIndexChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Location = new System.Drawing.Point(1053, 83);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 109;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnBuscartodos
            // 
            this.btnBuscartodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscartodos.Location = new System.Drawing.Point(966, 148);
            this.btnBuscartodos.Name = "btnBuscartodos";
            this.btnBuscartodos.Size = new System.Drawing.Size(116, 22);
            this.btnBuscartodos.TabIndex = 110;
            this.btnBuscartodos.Text = "Buscar todos";
            this.btnBuscartodos.UseVisualStyleBackColor = true;
            this.btnBuscartodos.Click += new System.EventHandler(this.btnBuscartodos_Click);
            // 
            // btnEliminarAprobados
            // 
            this.btnEliminarAprobados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminarAprobados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEliminarAprobados.Location = new System.Drawing.Point(12, 549);
            this.btnEliminarAprobados.Name = "btnEliminarAprobados";
            this.btnEliminarAprobados.Size = new System.Drawing.Size(116, 22);
            this.btnEliminarAprobados.TabIndex = 111;
            this.btnEliminarAprobados.Text = "Eliminar elemento";
            this.btnEliminarAprobados.UseVisualStyleBackColor = false;
            this.btnEliminarAprobados.Click += new System.EventHandler(this.btnEliminarAprobados_Click);
            // 
            // frmTablaComparativa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1140, 726);
            this.Controls.Add(this.btnEliminarAprobados);
            this.Controls.Add(this.btnBuscartodos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cboProveedor);
            this.Controls.Add(this.lstAprobados);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstTblacomparativa);
            this.Name = "frmTablaComparativa";
            this.Text = "TABLA COMPARATIVA";
            this.Load += new System.EventHandler(this.frmTablaComparativa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstTblacomparativa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView lstAprobados;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ComboBox cboProveedor;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnBuscartodos;
        private System.Windows.Forms.Button btnEliminarAprobados;
    }
}