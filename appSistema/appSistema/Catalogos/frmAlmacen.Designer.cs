namespace appSistema.Catalogos
{
    partial class frmAlmacen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlmacen));
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.mskCP = new System.Windows.Forms.MaskedTextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.txtColonia = new System.Windows.Forms.TextBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.msktxtNumero = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBuscarPlan = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gpBAcciones = new System.Windows.Forms.GroupBox();
            this.gpBConsultas = new System.Windows.Forms.GroupBox();
            this.gpBBuscar = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.gpBAcciones.SuspendLayout();
            this.gpBConsultas.SuspendLayout();
            this.gpBBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.Label1.Location = new System.Drawing.Point(48, 42);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(39, 16);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Clave";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label2.Location = new System.Drawing.Point(38, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label3.Location = new System.Drawing.Point(42, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ciudad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label4.Location = new System.Drawing.Point(40, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Colonia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label5.Location = new System.Drawing.Point(52, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Calle";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label6.Location = new System.Drawing.Point(10, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Código Postal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label7.Location = new System.Drawing.Point(19, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Descripcion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label8.Location = new System.Drawing.Point(35, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Numero ";
            // 
            // mskCP
            // 
            this.mskCP.Location = new System.Drawing.Point(99, 339);
            this.mskCP.Mask = "99999";
            this.mskCP.Name = "mskCP";
            this.mskCP.Size = new System.Drawing.Size(100, 23);
            this.mskCP.TabIndex = 9;
            this.mskCP.ValidatingType = typeof(int);
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(98, 42);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(100, 23);
            this.txtClave.TabIndex = 10;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(99, 77);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 23);
            this.txtDescripcion.TabIndex = 11;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(99, 120);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 23);
            this.txtNombre.TabIndex = 12;
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(99, 167);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(100, 23);
            this.txtCalle.TabIndex = 13;
            // 
            // txtColonia
            // 
            this.txtColonia.Location = new System.Drawing.Point(99, 257);
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.Size = new System.Drawing.Size(100, 23);
            this.txtColonia.TabIndex = 15;
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(99, 302);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(100, 23);
            this.txtCiudad.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.msktxtNumero);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.txtCiudad);
            this.groupBox1.Controls.Add(this.Label1);
            this.groupBox1.Controls.Add(this.txtColonia);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCalle);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtClave);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.mskCP);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 382);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Almacén";
            // 
            // msktxtNumero
            // 
            this.msktxtNumero.Location = new System.Drawing.Point(98, 206);
            this.msktxtNumero.Mask = "99999";
            this.msktxtNumero.Name = "msktxtNumero";
            this.msktxtNumero.Size = new System.Drawing.Size(100, 23);
            this.msktxtNumero.TabIndex = 17;
            this.msktxtNumero.ValidatingType = typeof(int);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label12.Location = new System.Drawing.Point(46, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 16);
            this.label12.TabIndex = 62;
            this.label12.Text = "Buscar:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(114, 31);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 60;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAceptar.Location = new System.Drawing.Point(6, 30);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 59;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnInsertar.Location = new System.Drawing.Point(19, 31);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 57;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnModificar.Location = new System.Drawing.Point(19, 60);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 58;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBuscarPlan
            // 
            this.btnBuscarPlan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscarPlan.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarPlan.Image")));
            this.btnBuscarPlan.Location = new System.Drawing.Point(103, 30);
            this.btnBuscarPlan.Name = "btnBuscarPlan";
            this.btnBuscarPlan.Size = new System.Drawing.Size(32, 32);
            this.btnBuscarPlan.TabIndex = 61;
            this.btnBuscarPlan.UseVisualStyleBackColor = true;
            this.btnBuscarPlan.Click += new System.EventHandler(this.btnBuscarPlan_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(6, 59);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 63;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // gpBAcciones
            // 
            this.gpBAcciones.Controls.Add(this.btnAceptar);
            this.gpBAcciones.Controls.Add(this.btnCancelar);
            this.gpBAcciones.Location = new System.Drawing.Point(316, 182);
            this.gpBAcciones.Name = "gpBAcciones";
            this.gpBAcciones.Size = new System.Drawing.Size(200, 100);
            this.gpBAcciones.TabIndex = 64;
            this.gpBAcciones.TabStop = false;
            // 
            // gpBConsultas
            // 
            this.gpBConsultas.Controls.Add(this.btnInsertar);
            this.gpBConsultas.Controls.Add(this.btnModificar);
            this.gpBConsultas.Controls.Add(this.btnEliminar);
            this.gpBConsultas.Location = new System.Drawing.Point(316, 22);
            this.gpBConsultas.Name = "gpBConsultas";
            this.gpBConsultas.Size = new System.Drawing.Size(200, 100);
            this.gpBConsultas.TabIndex = 65;
            this.gpBConsultas.TabStop = false;
            // 
            // gpBBuscar
            // 
            this.gpBBuscar.Controls.Add(this.btnBuscarPlan);
            this.gpBBuscar.Controls.Add(this.label12);
            this.gpBBuscar.Location = new System.Drawing.Point(589, 22);
            this.gpBBuscar.Name = "gpBBuscar";
            this.gpBBuscar.Size = new System.Drawing.Size(200, 100);
            this.gpBBuscar.TabIndex = 65;
            this.gpBBuscar.TabStop = false;
            // 
            // frmAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.gpBConsultas);
            this.Controls.Add(this.gpBBuscar);
            this.Controls.Add(this.gpBAcciones);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1364, 726);
            this.Name = "frmAlmacen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Almacén";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAlmacen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpBAcciones.ResumeLayout(false);
            this.gpBConsultas.ResumeLayout(false);
            this.gpBBuscar.ResumeLayout(false);
            this.gpBBuscar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mskCP;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.TextBox txtColonia;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnBuscarPlan;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox gpBAcciones;
        private System.Windows.Forms.GroupBox gpBConsultas;
        private System.Windows.Forms.GroupBox gpBBuscar;
        private System.Windows.Forms.MaskedTextBox msktxtNumero;
    }
}