namespace appSistema
{
    partial class frmContactoCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContactoCliente));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboTipoContacto = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mskExtension = new System.Windows.Forms.MaskedTextBox();
            this.maskTelefono = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboEmpresa = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtAM = new System.Windows.Forms.TextBox();
            this.txtAP = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboTipoContacto);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.mskExtension);
            this.groupBox1.Controls.Add(this.maskTelefono);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cboEmpresa);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtClave);
            this.groupBox1.Controls.Add(this.txtAM);
            this.groupBox1.Controls.Add(this.txtAP);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(646, 214);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contacto Cliente";
            // 
            // cboTipoContacto
            // 
            this.cboTipoContacto.FormattingEnabled = true;
            this.cboTipoContacto.Location = new System.Drawing.Point(512, 79);
            this.cboTipoContacto.Name = "cboTipoContacto";
            this.cboTipoContacto.Size = new System.Drawing.Size(121, 24);
            this.cboTipoContacto.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(417, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 16);
            this.label8.TabIndex = 34;
            this.label8.Text = "Tipo Contacto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "Extensión";
            // 
            // mskExtension
            // 
            this.mskExtension.Location = new System.Drawing.Point(79, 148);
            this.mskExtension.Mask = "99999";
            this.mskExtension.Name = "mskExtension";
            this.mskExtension.Size = new System.Drawing.Size(100, 23);
            this.mskExtension.TabIndex = 31;
            this.mskExtension.ValidatingType = typeof(int);
            // 
            // maskTelefono
            // 
            this.maskTelefono.Location = new System.Drawing.Point(79, 115);
            this.maskTelefono.Mask = "(999)000-0000";
            this.maskTelefono.Name = "maskTelefono";
            this.maskTelefono.Size = new System.Drawing.Size(100, 23);
            this.maskTelefono.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "Telefono";
            // 
            // cboEmpresa
            // 
            this.cboEmpresa.FormattingEnabled = true;
            this.cboEmpresa.Location = new System.Drawing.Point(512, 39);
            this.cboEmpresa.Name = "cboEmpresa";
            this.cboEmpresa.Size = new System.Drawing.Size(121, 24);
            this.cboEmpresa.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(443, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Empresa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Clave";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Apellido Materno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Apellido Paterno";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(79, 43);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(100, 23);
            this.txtClave.TabIndex = 2;
            // 
            // txtAM
            // 
            this.txtAM.Location = new System.Drawing.Point(307, 79);
            this.txtAM.Name = "txtAM";
            this.txtAM.Size = new System.Drawing.Size(100, 23);
            this.txtAM.TabIndex = 3;
            // 
            // txtAP
            // 
            this.txtAP.Location = new System.Drawing.Point(307, 42);
            this.txtAP.Name = "txtAP";
            this.txtAP.Size = new System.Drawing.Size(100, 23);
            this.txtAP.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(79, 80);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 23);
            this.txtNombre.TabIndex = 5;
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnInsertar.Location = new System.Drawing.Point(6, 18);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 52;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEliminar.Location = new System.Drawing.Point(6, 82);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 64;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGuardar.Location = new System.Drawing.Point(20, 19);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(104, 41);
            this.btnGuardar.TabIndex = 63;
            this.btnGuardar.Text = "Aceptar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnModificar.Location = new System.Drawing.Point(6, 47);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 62;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(54, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 66;
            this.label12.Text = "Buscar:";
            // 
            // btnBuscarPlan
            // 
            this.btnBuscarPlan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscarPlan.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarPlan.Image")));
            this.btnBuscarPlan.Location = new System.Drawing.Point(100, 47);
            this.btnBuscarPlan.Name = "btnBuscarPlan";
            this.btnBuscarPlan.Size = new System.Drawing.Size(32, 32);
            this.btnBuscarPlan.TabIndex = 65;
            this.btnBuscarPlan.UseVisualStyleBackColor = true;
            this.btnBuscarPlan.Click += new System.EventHandler(this.btnBuscarPlan_Click);
            // 
            // gpBBuscar
            // 
            this.gpBBuscar.Controls.Add(this.btnBuscarPlan);
            this.gpBBuscar.Controls.Add(this.label12);
            this.gpBBuscar.Location = new System.Drawing.Point(693, 232);
            this.gpBBuscar.Name = "gpBBuscar";
            this.gpBBuscar.Size = new System.Drawing.Size(237, 127);
            this.gpBBuscar.TabIndex = 72;
            this.gpBBuscar.TabStop = false;
            this.gpBBuscar.Visible = false;
            // 
            // gpBAcciones
            // 
            this.gpBAcciones.Controls.Add(this.BtnCancelar);
            this.gpBAcciones.Controls.Add(this.btnGuardar);
            this.gpBAcciones.Location = new System.Drawing.Point(130, 242);
            this.gpBAcciones.Name = "gpBAcciones";
            this.gpBAcciones.Size = new System.Drawing.Size(256, 115);
            this.gpBAcciones.TabIndex = 71;
            this.gpBAcciones.TabStop = false;
            this.gpBAcciones.Visible = false;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnCancelar.Location = new System.Drawing.Point(20, 66);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(104, 34);
            this.BtnCancelar.TabIndex = 43;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // gpBConsultas
            // 
            this.gpBConsultas.Controls.Add(this.btnInsertar);
            this.gpBConsultas.Controls.Add(this.btnModificar);
            this.gpBConsultas.Controls.Add(this.btnEliminar);
            this.gpBConsultas.Location = new System.Drawing.Point(421, 232);
            this.gpBConsultas.Name = "gpBConsultas";
            this.gpBConsultas.Size = new System.Drawing.Size(266, 127);
            this.gpBConsultas.TabIndex = 70;
            this.gpBConsultas.TabStop = false;
            // 
            // frmContactoCliente
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
            this.Name = "frmContactoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmContactoCliente_Load);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtAM;
        private System.Windows.Forms.TextBox txtAP;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cboEmpresa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mskExtension;
        private System.Windows.Forms.MaskedTextBox maskTelefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboTipoContacto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnBuscarPlan;
        private System.Windows.Forms.GroupBox gpBBuscar;
        private System.Windows.Forms.GroupBox gpBAcciones;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.GroupBox gpBConsultas;
    }
}