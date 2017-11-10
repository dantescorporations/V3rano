namespace appSistema
{
    partial class frmDevolucionSobreVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDevolucionSobreVenta));
            this.lblDatosProducto = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblDatosFactura = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscarFac = new System.Windows.Forms.Button();
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
            this.lblDatosProducto.Location = new System.Drawing.Point(195, 94);
            this.lblDatosProducto.Name = "lblDatosProducto";
            this.lblDatosProducto.Size = new System.Drawing.Size(13, 13);
            this.lblDatosProducto.TabIndex = 32;
            this.lblDatosProducto.Text = "--";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Buscar Producto";
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(22, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 32);
            this.button2.TabIndex = 30;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblDatosFactura
            // 
            this.lblDatosFactura.AutoSize = true;
            this.lblDatosFactura.Location = new System.Drawing.Point(195, 27);
            this.lblDatosFactura.Name = "lblDatosFactura";
            this.lblDatosFactura.Size = new System.Drawing.Size(13, 13);
            this.lblDatosFactura.TabIndex = 29;
            this.lblDatosFactura.Text = "--";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Buscar Factura";
            // 
            // btnBuscarFac
            // 
            this.btnBuscarFac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscarFac.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarFac.Image")));
            this.btnBuscarFac.Location = new System.Drawing.Point(22, 18);
            this.btnBuscarFac.Name = "btnBuscarFac";
            this.btnBuscarFac.Size = new System.Drawing.Size(32, 32);
            this.btnBuscarFac.TabIndex = 27;
            this.btnBuscarFac.UseVisualStyleBackColor = true;
            this.btnBuscarFac.Click += new System.EventHandler(this.btnBuscarFac_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkAtriculoNS);
            this.groupBox1.Controls.Add(this.chkArticuloDañado);
            this.groupBox1.Location = new System.Drawing.Point(18, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 114);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Motivo de devolución ";
            // 
            // chkAtriculoNS
            // 
            this.chkAtriculoNS.AutoSize = true;
            this.chkAtriculoNS.Location = new System.Drawing.Point(17, 67);
            this.chkAtriculoNS.Name = "chkAtriculoNS";
            this.chkAtriculoNS.Size = new System.Drawing.Size(123, 17);
            this.chkAtriculoNS.TabIndex = 5;
            this.chkAtriculoNS.Text = "Articulo no solicitado";
            this.chkAtriculoNS.UseVisualStyleBackColor = true;
            // 
            // chkArticuloDañado
            // 
            this.chkArticuloDañado.AutoSize = true;
            this.chkArticuloDañado.Location = new System.Drawing.Point(17, 44);
            this.chkArticuloDañado.Name = "chkArticuloDañado";
            this.chkArticuloDañado.Size = new System.Drawing.Size(100, 17);
            this.chkArticuloDañado.TabIndex = 4;
            this.chkArticuloDañado.Text = "Articulo dañado";
            this.chkArticuloDañado.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 25;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(128, 263);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(55, 23);
            this.btnAceptar.TabIndex = 24;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmDevolucionSobreVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(347, 320);
            this.Controls.Add(this.lblDatosProducto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblDatosFactura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBuscarFac);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAceptar);
            this.Name = "frmDevolucionSobreVenta";
            this.Text = "frmDevolucionSobreVenta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDatosProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblDatosFactura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscarFac;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkAtriculoNS;
        private System.Windows.Forms.CheckBox chkArticuloDañado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAceptar;

    }
}