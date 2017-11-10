namespace appSistema.Módulos
{
    partial class frmCuentasPorPagar
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
            this.lstC = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lstC
            // 
            this.lstC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstC.FullRowSelect = true;
            this.lstC.GridLines = true;
            this.lstC.Location = new System.Drawing.Point(12, 12);
            this.lstC.Name = "lstC";
            this.lstC.Size = new System.Drawing.Size(494, 242);
            this.lstC.TabIndex = 62;
            this.lstC.UseCompatibleStateImageBehavior = false;
            this.lstC.View = System.Windows.Forms.View.Details;
            // 
            // frmCuentasPorPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(520, 261);
            this.Controls.Add(this.lstC);
            this.Name = "frmCuentasPorPagar";
            this.Text = "frmCuentasPorPagar";
            this.Load += new System.EventHandler(this.frmCuentasPorPagar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstC;
    }
}