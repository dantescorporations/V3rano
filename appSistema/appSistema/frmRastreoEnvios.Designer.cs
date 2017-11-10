namespace appSistema
{
    partial class frmRastreoEnvios
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
            this.lstvEnvios = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstvEnvios
            // 
            this.lstvEnvios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstvEnvios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lstvEnvios.GridLines = true;
            this.lstvEnvios.Location = new System.Drawing.Point(40, 26);
            this.lstvEnvios.Name = "lstvEnvios";
            this.lstvEnvios.Size = new System.Drawing.Size(818, 283);
            this.lstvEnvios.TabIndex = 0;
            this.lstvEnvios.UseCompatibleStateImageBehavior = false;
            this.lstvEnvios.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "#";
            this.columnHeader1.Width = 42;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Fecha";
            this.columnHeader2.Width = 77;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Requisición";
            this.columnHeader3.Width = 158;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Orden de Compra";
            this.columnHeader4.Width = 122;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Paquetería";
            this.columnHeader5.Width = 165;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ocurre/Domicilio";
            this.columnHeader6.Width = 127;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Trakin Number";
            this.columnHeader7.Width = 123;
            // 
            // frmRastreoEnvios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(897, 321);
            this.Controls.Add(this.lstvEnvios);
            this.Name = "frmRastreoEnvios";
            this.Text = "RastreoEnvios";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstvEnvios;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}