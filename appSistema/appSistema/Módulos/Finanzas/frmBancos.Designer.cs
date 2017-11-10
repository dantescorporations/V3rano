namespace appSistema.Módulos
{
    partial class frmBancos
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstE = new System.Windows.Forms.ListView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstS = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.lstEntradas = new System.Windows.Forms.ListView();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.lstE);
            this.groupBox4.Location = new System.Drawing.Point(391, 267);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(170, 50);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total Salidas:";
            // 
            // lstE
            // 
            this.lstE.Location = new System.Drawing.Point(82, 19);
            this.lstE.Name = "lstE";
            this.lstE.Size = new System.Drawing.Size(77, 22);
            this.lstE.TabIndex = 29;
            this.lstE.UseCompatibleStateImageBehavior = false;
            this.lstE.View = System.Windows.Forms.View.List;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.lstS);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(391, 211);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(170, 50);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            // 
            // lstS
            // 
            this.lstS.Location = new System.Drawing.Point(82, 19);
            this.lstS.Name = "lstS";
            this.lstS.Size = new System.Drawing.Size(77, 21);
            this.lstS.TabIndex = 31;
            this.lstS.UseCompatibleStateImageBehavior = false;
            this.lstS.View = System.Windows.Forms.View.List;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total Entradas:";
            // 
            // lstEntradas
            // 
            this.lstEntradas.GridLines = true;
            this.lstEntradas.Location = new System.Drawing.Point(21, 12);
            this.lstEntradas.Name = "lstEntradas";
            this.lstEntradas.Size = new System.Drawing.Size(541, 180);
            this.lstEntradas.TabIndex = 28;
            this.lstEntradas.UseCompatibleStateImageBehavior = false;
            this.lstEntradas.View = System.Windows.Forms.View.Details;
            // 
            // frmBancos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(581, 328);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lstEntradas);
            this.Name = "frmBancos";
            this.Text = "frmBancos";
            this.Load += new System.EventHandler(this.frmBancos_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lstE;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView lstS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lstEntradas;
    }
}