namespace appSistema
{
    partial class frmCostoProduccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCostoProduccion));
            this.txtNombrePlan = new System.Windows.Forms.TextBox();
            this.txtPlan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lstvRequisicion = new System.Windows.Forms.ListView();
            this.IdProducto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.precio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.unidades = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.btnBuscarPlan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombrePlan
            // 
            this.txtNombrePlan.Location = new System.Drawing.Point(300, 166);
            this.txtNombrePlan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombrePlan.Name = "txtNombrePlan";
            this.txtNombrePlan.Size = new System.Drawing.Size(59, 23);
            this.txtNombrePlan.TabIndex = 12;
            this.txtNombrePlan.Text = "50";
            // 
            // txtPlan
            // 
            this.txtPlan.Location = new System.Drawing.Point(135, 15);
            this.txtPlan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPlan.Name = "txtPlan";
            this.txtPlan.Size = new System.Drawing.Size(80, 23);
            this.txtPlan.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Orden de Trabajo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label5.Location = new System.Drawing.Point(61, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Producto:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(135, 68);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(80, 23);
            this.textBox3.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(258, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Nombre: Producto1 Precio: $100.00 Undad:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(366, 162);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(68, 31);
            this.btnAgregar.TabIndex = 23;
            this.btnAgregar.Text = ">";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lstvRequisicion
            // 
            this.lstvRequisicion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstvRequisicion.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdProducto,
            this.nombre,
            this.precio,
            this.unidades});
            this.lstvRequisicion.GridLines = true;
            this.lstvRequisicion.Location = new System.Drawing.Point(14, 210);
            this.lstvRequisicion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstvRequisicion.Name = "lstvRequisicion";
            this.lstvRequisicion.Size = new System.Drawing.Size(629, 272);
            this.lstvRequisicion.TabIndex = 24;
            this.lstvRequisicion.UseCompatibleStateImageBehavior = false;
            this.lstvRequisicion.View = System.Windows.Forms.View.Details;
            this.lstvRequisicion.SelectedIndexChanged += new System.EventHandler(this.lstvRequisicion_SelectedIndexChanged);
            // 
            // IdProducto
            // 
            this.IdProducto.Text = "IdProducto";
            this.IdProducto.Width = 69;
            // 
            // nombre
            // 
            this.nombre.Text = "Nombre";
            this.nombre.Width = 128;
            // 
            // precio
            // 
            this.precio.Text = "Precio";
            this.precio.Width = 111;
            // 
            // unidades
            // 
            this.unidades.Text = "Unidades";
            this.unidades.Width = 227;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dateTimePicker1.Location = new System.Drawing.Point(401, 33);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(242, 23);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.lblEmpleado.Location = new System.Drawing.Point(401, 11);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(69, 16);
            this.lblEmpleado.TabIndex = 25;
            this.lblEmpleado.Text = "Empleado:";
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarProducto.Image")));
            this.btnBuscarProducto.Location = new System.Drawing.Point(223, 59);
            this.btnBuscarProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(37, 39);
            this.btnBuscarProducto.TabIndex = 28;
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // btnBuscarPlan
            // 
            this.btnBuscarPlan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscarPlan.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarPlan.Image")));
            this.btnBuscarPlan.Location = new System.Drawing.Point(223, 10);
            this.btnBuscarPlan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscarPlan.Name = "btnBuscarPlan";
            this.btnBuscarPlan.Size = new System.Drawing.Size(37, 39);
            this.btnBuscarPlan.TabIndex = 27;
            this.btnBuscarPlan.UseVisualStyleBackColor = true;
            // 
            // frmCostoProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(663, 510);
            this.Controls.Add(this.btnBuscarProducto);
            this.Controls.Add(this.btnBuscarPlan);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.lstvRequisicion);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNombrePlan);
            this.Controls.Add(this.txtPlan);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCostoProduccion";
            this.Text = "Costo de Produccion";
            this.Load += new System.EventHandler(this.Requizicion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombrePlan;
        private System.Windows.Forms.TextBox txtPlan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListView lstvRequisicion;
        private System.Windows.Forms.ColumnHeader IdProducto;
        private System.Windows.Forms.ColumnHeader nombre;
        private System.Windows.Forms.ColumnHeader precio;
        private System.Windows.Forms.ColumnHeader unidades;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Button btnBuscarPlan;
        private System.Windows.Forms.Button btnBuscarProducto;
    }
}