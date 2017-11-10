namespace appSistema.Catalogos
{
    partial class frmTipoContactoCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTipoContactoCliente));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBuscarPlan = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
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
            this.groupBox1.Location = new System.Drawing.Point(14, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 94);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Contacto Cliente";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(107, 40);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(262, 20);
            this.txtDescripcion.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Descripcón ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 63;
            this.label7.Text = "Buscar :";
            // 
            // btnBuscarPlan
            // 
            this.btnBuscarPlan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscarPlan.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarPlan.Image")));
            this.btnBuscarPlan.Location = new System.Drawing.Point(71, 35);
            this.btnBuscarPlan.Name = "btnBuscarPlan";
            this.btnBuscarPlan.Size = new System.Drawing.Size(32, 32);
            this.btnBuscarPlan.TabIndex = 62;
            this.btnBuscarPlan.UseVisualStyleBackColor = true;
            this.btnBuscarPlan.Click += new System.EventHandler(this.btnBuscarPlan_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEliminar.Location = new System.Drawing.Point(6, 86);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 61;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGuardar.Location = new System.Drawing.Point(30, 19);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 53;
            this.btnGuardar.Text = "Aceptar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnInsertar.Location = new System.Drawing.Point(6, 31);
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
            this.btnModificar.Location = new System.Drawing.Point(6, 57);
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
            this.gpBBuscar.Location = new System.Drawing.Point(618, 159);
            this.gpBBuscar.Name = "gpBBuscar";
            this.gpBBuscar.Size = new System.Drawing.Size(237, 145);
            this.gpBBuscar.TabIndex = 69;
            this.gpBBuscar.TabStop = false;
            this.gpBBuscar.Visible = false;
            // 
            // gpBAcciones
            // 
            this.gpBAcciones.Controls.Add(this.BtnCancelar);
            this.gpBAcciones.Controls.Add(this.btnGuardar);
            this.gpBAcciones.Location = new System.Drawing.Point(346, 344);
            this.gpBAcciones.Name = "gpBAcciones";
            this.gpBAcciones.Size = new System.Drawing.Size(256, 115);
            this.gpBAcciones.TabIndex = 68;
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
            this.gpBConsultas.Controls.Add(this.btnInsertar);
            this.gpBConsultas.Controls.Add(this.btnModificar);
            this.gpBConsultas.Location = new System.Drawing.Point(346, 159);
            this.gpBConsultas.Name = "gpBConsultas";
            this.gpBConsultas.Size = new System.Drawing.Size(266, 145);
            this.gpBConsultas.TabIndex = 67;
            this.gpBConsultas.TabStop = false;
            // 
            // frmTipoContactoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(892, 495);
            this.Controls.Add(this.gpBBuscar);
            this.Controls.Add(this.gpBAcciones);
            this.Controls.Add(this.gpBConsultas);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTipoContactoCliente";
            this.Text = "ContactoCLiente";
            this.Load += new System.EventHandler(this.frmTipoContactoCliente_Load);
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
        private System.Windows.Forms.Button btnGuardar;
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