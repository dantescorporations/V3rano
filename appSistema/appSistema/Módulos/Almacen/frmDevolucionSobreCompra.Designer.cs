namespace appSistema
{
    partial class frmDevolucionSobreCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDevolucionSobreCompra));
            this.lblDatosProducto = new System.Windows.Forms.Label();
            this.lblDatosFactura = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnProd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFact = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkAtriculoNS = new System.Windows.Forms.CheckBox();
            this.chkArticuloDañado = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDatosProducto
            // 
            this.lblDatosProducto.AutoSize = true;
            this.lblDatosProducto.Location = new System.Drawing.Point(176, 99);
            this.lblDatosProducto.Name = "lblDatosProducto";
            this.lblDatosProducto.Size = new System.Drawing.Size(13, 13);
            this.lblDatosProducto.TabIndex = 27;
            this.lblDatosProducto.Text = "--";
            // 
            // lblDatosFactura
            // 
            this.lblDatosFactura.AutoSize = true;
            this.lblDatosFactura.Location = new System.Drawing.Point(176, 29);
            this.lblDatosFactura.Name = "lblDatosFactura";
            this.lblDatosFactura.Size = new System.Drawing.Size(13, 13);
            this.lblDatosFactura.TabIndex = 26;
            this.lblDatosFactura.Text = "--";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Buscar Producto";
            // 
            // btnProd
            // 
            this.btnProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProd.Image = ((System.Drawing.Image)(resources.GetObject("btnProd.Image")));
            this.btnProd.Location = new System.Drawing.Point(32, 90);
            this.btnProd.Name = "btnProd";
            this.btnProd.Size = new System.Drawing.Size(32, 32);
            this.btnProd.TabIndex = 24;
            this.btnProd.UseVisualStyleBackColor = true;
            this.btnProd.Click += new System.EventHandler(this.btnProd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Buscar Factura";
            // 
            // btnFact
            // 
            this.btnFact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFact.Image = ((System.Drawing.Image)(resources.GetObject("btnFact.Image")));
            this.btnFact.Location = new System.Drawing.Point(32, 20);
            this.btnFact.Name = "btnFact";
            this.btnFact.Size = new System.Drawing.Size(32, 32);
            this.btnFact.TabIndex = 22;
            this.btnFact.UseVisualStyleBackColor = true;
            this.btnFact.Click += new System.EventHandler(this.btnFact_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkAtriculoNS);
            this.groupBox1.Controls.Add(this.chkArticuloDañado);
            this.groupBox1.Location = new System.Drawing.Point(32, 175);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 120);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Motivo de devolución ";
            // 
            // chkAtriculoNS
            // 
            this.chkAtriculoNS.AutoSize = true;
            this.chkAtriculoNS.Location = new System.Drawing.Point(27, 67);
            this.chkAtriculoNS.Name = "chkAtriculoNS";
            this.chkAtriculoNS.Size = new System.Drawing.Size(123, 17);
            this.chkAtriculoNS.TabIndex = 5;
            this.chkAtriculoNS.Text = "Articulo no solicitado";
            this.chkAtriculoNS.UseVisualStyleBackColor = true;
            // 
            // chkArticuloDañado
            // 
            this.chkArticuloDañado.AutoSize = true;
            this.chkArticuloDañado.Location = new System.Drawing.Point(27, 43);
            this.chkArticuloDañado.Name = "chkArticuloDañado";
            this.chkArticuloDañado.Size = new System.Drawing.Size(100, 17);
            this.chkArticuloDañado.TabIndex = 4;
            this.chkArticuloDañado.Text = "Articulo dañado";
            this.chkArticuloDañado.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 20;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(160, 302);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(55, 23);
            this.btnAceptar.TabIndex = 19;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmDevolucionSobreCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(365, 349);
            this.Controls.Add(this.lblDatosProducto);
            this.Controls.Add(this.lblDatosFactura);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnProd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnFact);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAceptar);
            this.Name = "frmDevolucionSobreCompra";
            this.Text = "Devolucion Sobre Compra";
            this.Load += new System.EventHandler(this.frmDevolucionSobreCompra_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDatosProducto;
        private System.Windows.Forms.Label lblDatosFactura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnProd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFact;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkAtriculoNS;
        private System.Windows.Forms.CheckBox chkArticuloDañado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAceptar;

    }
}