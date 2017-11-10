namespace appSistema
{
    partial class frmGastos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGastos));
            this.label7 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboEmpleado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.cboTipoGasto = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBuscarPlan = new System.Windows.Forms.Button();
            this.gpBBuscar = new System.Windows.Forms.GroupBox();
            this.gpBAcciones = new System.Windows.Forms.GroupBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.gpBConsultas = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.gpBBuscar.SuspendLayout();
            this.gpBAcciones.SuspendLayout();
            this.gpBConsultas.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Buscar :";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGuardar.Location = new System.Drawing.Point(30, 19);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 20);
            this.btnGuardar.TabIndex = 34;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnModificar.Location = new System.Drawing.Point(15, 41);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 20);
            this.btnModificar.TabIndex = 33;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEliminar.Location = new System.Drawing.Point(15, 67);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 20);
            this.btnEliminar.TabIndex = 32;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnInsertar.Location = new System.Drawing.Point(15, 15);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 20);
            this.btnInsertar.TabIndex = 31;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboEmpleado);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtImporte);
            this.groupBox1.Controls.Add(this.cboTipoGasto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 206);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Gasto";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cboEmpleado
            // 
            this.cboEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmpleado.FormattingEnabled = true;
            this.cboEmpleado.Location = new System.Drawing.Point(104, 129);
            this.cboEmpleado.Name = "cboEmpleado";
            this.cboEmpleado.Size = new System.Drawing.Size(121, 24);
            this.cboEmpleado.TabIndex = 37;
            this.cboEmpleado.Tag = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 36;
            this.label3.Text = "Usuario :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "Importe";
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(104, 58);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(100, 23);
            this.txtImporte.TabIndex = 34;
            // 
            // cboTipoGasto
            // 
            this.cboTipoGasto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoGasto.FormattingEnabled = true;
            this.cboTipoGasto.Items.AddRange(new object[] {
            "1",
            "0"});
            this.cboTipoGasto.Location = new System.Drawing.Point(104, 92);
            this.cboTipoGasto.Name = "cboTipoGasto";
            this.cboTipoGasto.Size = new System.Drawing.Size(121, 24);
            this.cboTipoGasto.TabIndex = 33;
            this.cboTipoGasto.Tag = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tipo de gasto";
            // 
            // btnBuscarPlan
            // 
            this.btnBuscarPlan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscarPlan.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarPlan.Image")));
            this.btnBuscarPlan.Location = new System.Drawing.Point(52, 41);
            this.btnBuscarPlan.Name = "btnBuscarPlan";
            this.btnBuscarPlan.Size = new System.Drawing.Size(32, 29);
            this.btnBuscarPlan.TabIndex = 35;
            this.btnBuscarPlan.UseVisualStyleBackColor = true;
            this.btnBuscarPlan.Click += new System.EventHandler(this.btnBuscarPlan_Click);
            // 
            // gpBBuscar
            // 
            this.gpBBuscar.Controls.Add(this.btnBuscarPlan);
            this.gpBBuscar.Controls.Add(this.label7);
            this.gpBBuscar.Location = new System.Drawing.Point(672, 50);
            this.gpBBuscar.Name = "gpBBuscar";
            this.gpBBuscar.Size = new System.Drawing.Size(237, 145);
            this.gpBBuscar.TabIndex = 72;
            this.gpBBuscar.TabStop = false;
            this.gpBBuscar.Visible = false;
            // 
            // gpBAcciones
            // 
            this.gpBAcciones.Controls.Add(this.BtnCancelar);
            this.gpBAcciones.Controls.Add(this.btnGuardar);
            this.gpBAcciones.Location = new System.Drawing.Point(400, 235);
            this.gpBAcciones.Name = "gpBAcciones";
            this.gpBAcciones.Size = new System.Drawing.Size(256, 115);
            this.gpBAcciones.TabIndex = 71;
            this.gpBAcciones.TabStop = false;
            this.gpBAcciones.Visible = false;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnCancelar.Location = new System.Drawing.Point(30, 76);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(84, 32);
            this.BtnCancelar.TabIndex = 43;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // gpBConsultas
            // 
            this.gpBConsultas.Controls.Add(this.btnModificar);
            this.gpBConsultas.Controls.Add(this.btnInsertar);
            this.gpBConsultas.Controls.Add(this.btnEliminar);
            this.gpBConsultas.Location = new System.Drawing.Point(400, 50);
            this.gpBConsultas.Name = "gpBConsultas";
            this.gpBConsultas.Size = new System.Drawing.Size(266, 145);
            this.gpBConsultas.TabIndex = 70;
            this.gpBConsultas.TabStop = false;
            // 
            // frmGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.gpBBuscar);
            this.Controls.Add(this.gpBAcciones);
            this.Controls.Add(this.gpBConsultas);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1364, 726);
            this.Name = "frmGastos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gastos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGastos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpBBuscar.ResumeLayout(false);
            this.gpBBuscar.PerformLayout();
            this.gpBAcciones.ResumeLayout(false);
            this.gpBConsultas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBuscarPlan;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboTipoGasto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.ComboBox cboEmpleado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gpBBuscar;
        private System.Windows.Forms.GroupBox gpBAcciones;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.GroupBox gpBConsultas;
    }
}