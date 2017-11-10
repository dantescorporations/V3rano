namespace appSistema
{
    partial class frmTipoGasto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTipoGasto));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBuscarPlan = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(238, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 91);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de gasto";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(93, 43);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(243, 20);
            this.txtDescripcion.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Descripcón ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 63;
            this.label7.Text = "Buscar :";
            // 
            // btnBuscarPlan
            // 
            this.btnBuscarPlan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscarPlan.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarPlan.Image")));
            this.btnBuscarPlan.Location = new System.Drawing.Point(103, 59);
            this.btnBuscarPlan.Name = "btnBuscarPlan";
            this.btnBuscarPlan.Size = new System.Drawing.Size(32, 32);
            this.btnBuscarPlan.TabIndex = 62;
            this.btnBuscarPlan.UseVisualStyleBackColor = true;
            this.btnBuscarPlan.Click += new System.EventHandler(this.btnBuscarPlan_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEliminar.Location = new System.Drawing.Point(54, 61);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 61;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAceptar.Location = new System.Drawing.Point(30, 34);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 53;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnInsertar.Location = new System.Drawing.Point(54, 32);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 51;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnModificar.Location = new System.Drawing.Point(54, 90);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 52;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // gpBBuscar
            // 
            this.gpBBuscar.Controls.Add(this.btnBuscarPlan);
            this.gpBBuscar.Controls.Add(this.label7);
            this.gpBBuscar.Location = new System.Drawing.Point(915, 43);
            this.gpBBuscar.Name = "gpBBuscar";
            this.gpBBuscar.Size = new System.Drawing.Size(237, 145);
            this.gpBBuscar.TabIndex = 66;
            this.gpBBuscar.TabStop = false;
            this.gpBBuscar.Visible = false;
            // 
            // gpBAcciones
            // 
            this.gpBAcciones.Controls.Add(this.BtnCancelar);
            this.gpBAcciones.Controls.Add(this.btnAceptar);
            this.gpBAcciones.Location = new System.Drawing.Point(643, 228);
            this.gpBAcciones.Name = "gpBAcciones";
            this.gpBAcciones.Size = new System.Drawing.Size(256, 115);
            this.gpBAcciones.TabIndex = 65;
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
            this.gpBConsultas.Controls.Add(this.btnEliminar);
            this.gpBConsultas.Controls.Add(this.btnModificar);
            this.gpBConsultas.Controls.Add(this.btnInsertar);
            this.gpBConsultas.Location = new System.Drawing.Point(643, 43);
            this.gpBConsultas.Name = "gpBConsultas";
            this.gpBConsultas.Size = new System.Drawing.Size(266, 145);
            this.gpBConsultas.TabIndex = 64;
            this.gpBConsultas.TabStop = false;
            // 
            // frmTipoGasto
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
            this.Name = "frmTipoGasto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTipoGasto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTipoGasto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpBBuscar.ResumeLayout(false);
            this.gpBBuscar.PerformLayout();
            this.gpBAcciones.ResumeLayout(false);
            this.gpBConsultas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBuscarPlan;
        private System.Windows.Forms.GroupBox gpBBuscar;
        private System.Windows.Forms.GroupBox gpBAcciones;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.GroupBox gpBConsultas;
    }
}