namespace appSistema
{
    partial class frmEntradaAlmacen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEntradaAlmacen));
            this.btnEnlazar = new System.Windows.Forms.Button();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblProyecto = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblOC = new System.Windows.Forms.Label();
            this.btnHecho = new System.Windows.Forms.Button();
            this.ltvfacturas = new System.Windows.Forms.ListView();
            this.ltvEntrada = new System.Windows.Forms.ListView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarOC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEnlazar
            // 
            this.btnEnlazar.Location = new System.Drawing.Point(467, 213);
            this.btnEnlazar.Name = "btnEnlazar";
            this.btnEnlazar.Size = new System.Drawing.Size(75, 49);
            this.btnEnlazar.TabIndex = 37;
            this.btnEnlazar.Text = "<<";
            this.btnEnlazar.UseVisualStyleBackColor = true;
            this.btnEnlazar.Click += new System.EventHandler(this.btnEnlazar_Click_1);
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(569, 68);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(13, 13);
            this.lblMonto.TabIndex = 36;
            this.lblMonto.Text = "_";
            // 
            // lblProyecto
            // 
            this.lblProyecto.AutoSize = true;
            this.lblProyecto.Location = new System.Drawing.Point(581, 23);
            this.lblProyecto.Name = "lblProyecto";
            this.lblProyecto.Size = new System.Drawing.Size(13, 13);
            this.lblProyecto.TabIndex = 35;
            this.lblProyecto.Text = "_";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(311, 68);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(13, 13);
            this.lblFecha.TabIndex = 34;
            this.lblFecha.Text = "_";
            // 
            // lblOC
            // 
            this.lblOC.AutoSize = true;
            this.lblOC.Location = new System.Drawing.Point(311, 23);
            this.lblOC.Name = "lblOC";
            this.lblOC.Size = new System.Drawing.Size(13, 13);
            this.lblOC.TabIndex = 33;
            this.lblOC.Text = "_";
            // 
            // btnHecho
            // 
            this.btnHecho.Location = new System.Drawing.Point(802, 392);
            this.btnHecho.Name = "btnHecho";
            this.btnHecho.Size = new System.Drawing.Size(75, 23);
            this.btnHecho.TabIndex = 32;
            this.btnHecho.Text = "Hecho";
            this.btnHecho.UseVisualStyleBackColor = true;
            this.btnHecho.Click += new System.EventHandler(this.btnHecho_Click);
            // 
            // ltvfacturas
            // 
            this.ltvfacturas.FullRowSelect = true;
            this.ltvfacturas.GridLines = true;
            this.ltvfacturas.Location = new System.Drawing.Point(548, 92);
            this.ltvfacturas.Name = "ltvfacturas";
            this.ltvfacturas.Size = new System.Drawing.Size(329, 294);
            this.ltvfacturas.TabIndex = 31;
            this.ltvfacturas.UseCompatibleStateImageBehavior = false;
            this.ltvfacturas.View = System.Windows.Forms.View.Details;
            // 
            // ltvEntrada
            // 
            this.ltvEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ltvEntrada.FullRowSelect = true;
            this.ltvEntrada.GridLines = true;
            this.ltvEntrada.Location = new System.Drawing.Point(18, 102);
            this.ltvEntrada.Name = "ltvEntrada";
            this.ltvEntrada.Size = new System.Drawing.Size(443, 276);
            this.ltvEntrada.TabIndex = 30;
            this.ltvEntrada.UseCompatibleStateImageBehavior = false;
            this.ltvEntrada.View = System.Windows.Forms.View.Details;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(510, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Monto :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(253, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Fecha :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(507, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "O.T N° :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "O.C  N° :";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtObservaciones.Location = new System.Drawing.Point(18, 407);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(206, 64);
            this.txtObservaciones.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Observaciones :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Orden de compra";
            // 
            // btnBuscarOC
            // 
            this.btnBuscarOC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscarOC.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarOC.Image")));
            this.btnBuscarOC.Location = new System.Drawing.Point(32, 31);
            this.btnBuscarOC.Name = "btnBuscarOC";
            this.btnBuscarOC.Size = new System.Drawing.Size(32, 32);
            this.btnBuscarOC.TabIndex = 22;
            this.btnBuscarOC.UseVisualStyleBackColor = true;
            this.btnBuscarOC.Click += new System.EventHandler(this.btnBuscarOC_Click);
            // 
            // frmEntradaAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(973, 475);
            this.Controls.Add(this.btnEnlazar);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblProyecto);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblOC);
            this.Controls.Add(this.btnHecho);
            this.Controls.Add(this.ltvfacturas);
            this.Controls.Add(this.ltvEntrada);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscarOC);
            this.Name = "frmEntradaAlmacen";
            this.Text = "Entrada de Almacen";
            this.Load += new System.EventHandler(this.frmEntradaAlmacen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnlazar;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblProyecto;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblOC;
        private System.Windows.Forms.Button btnHecho;
        private System.Windows.Forms.ListView ltvfacturas;
        private System.Windows.Forms.ListView ltvEntrada;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarOC;

    }
}