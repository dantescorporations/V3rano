namespace appSistema
{
    partial class frmPermisos
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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnN = new System.Windows.Forms.Button();
            this.btnNT = new System.Windows.Forms.Button();
            this.btnV = new System.Windows.Forms.Button();
            this.btnVT = new System.Windows.Forms.Button();
            this.cboUsuario = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ltbPermisosN = new System.Windows.Forms.ListBox();
            this.ltbPermisosV = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.lblUsuario.Location = new System.Drawing.Point(27, 36);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(60, 16);
            this.lblUsuario.TabIndex = 18;
            this.lblUsuario.Text = "Usuario :";
            // 
            // btnN
            // 
            this.btnN.Location = new System.Drawing.Point(293, 518);
            this.btnN.Name = "btnN";
            this.btnN.Size = new System.Drawing.Size(51, 35);
            this.btnN.TabIndex = 15;
            this.btnN.Text = "<";
            this.btnN.UseVisualStyleBackColor = true;
            this.btnN.Click += new System.EventHandler(this.btnN_Click);
            // 
            // btnNT
            // 
            this.btnNT.Location = new System.Drawing.Point(293, 477);
            this.btnNT.Name = "btnNT";
            this.btnNT.Size = new System.Drawing.Size(51, 35);
            this.btnNT.TabIndex = 14;
            this.btnNT.Text = "<<";
            this.btnNT.UseVisualStyleBackColor = true;
            this.btnNT.Click += new System.EventHandler(this.btnNT_Click);
            // 
            // btnV
            // 
            this.btnV.Location = new System.Drawing.Point(293, 354);
            this.btnV.Name = "btnV";
            this.btnV.Size = new System.Drawing.Size(51, 35);
            this.btnV.TabIndex = 13;
            this.btnV.Text = ">";
            this.btnV.UseVisualStyleBackColor = true;
            this.btnV.Click += new System.EventHandler(this.btnV_Click);
            // 
            // btnVT
            // 
            this.btnVT.Location = new System.Drawing.Point(293, 313);
            this.btnVT.Name = "btnVT";
            this.btnVT.Size = new System.Drawing.Size(51, 35);
            this.btnVT.TabIndex = 12;
            this.btnVT.Text = ">>";
            this.btnVT.UseVisualStyleBackColor = true;
            this.btnVT.Click += new System.EventHandler(this.btnVT_Click);
            // 
            // cboUsuario
            // 
            this.cboUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUsuario.FormattingEnabled = true;
            this.cboUsuario.Location = new System.Drawing.Point(93, 36);
            this.cboUsuario.Name = "cboUsuario";
            this.cboUsuario.Size = new System.Drawing.Size(121, 21);
            this.cboUsuario.TabIndex = 20;
            this.cboUsuario.SelectedIndexChanged += new System.EventHandler(this.cboUsuario_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label1.Location = new System.Drawing.Point(41, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "_";
            // 
            // ltbPermisosN
            // 
            this.ltbPermisosN.AllowDrop = true;
            this.ltbPermisosN.FormattingEnabled = true;
            this.ltbPermisosN.Location = new System.Drawing.Point(18, 215);
            this.ltbPermisosN.Name = "ltbPermisosN";
            this.ltbPermisosN.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ltbPermisosN.Size = new System.Drawing.Size(269, 420);
            this.ltbPermisosN.TabIndex = 22;
            // 
            // ltbPermisosV
            // 
            this.ltbPermisosV.AllowDrop = true;
            this.ltbPermisosV.FormattingEnabled = true;
            this.ltbPermisosV.Location = new System.Drawing.Point(350, 215);
            this.ltbPermisosV.Name = "ltbPermisosV";
            this.ltbPermisosV.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ltbPermisosV.Size = new System.Drawing.Size(283, 420);
            this.ltbPermisosV.TabIndex = 23;
            // 
            // frmPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(645, 659);
            this.Controls.Add(this.ltbPermisosV);
            this.Controls.Add(this.ltbPermisosN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnN);
            this.Controls.Add(this.btnNT);
            this.Controls.Add(this.btnV);
            this.Controls.Add(this.btnVT);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(661, 698);
            this.MinimumSize = new System.Drawing.Size(661, 698);
            this.Name = "frmPermisos";
            this.Text = "frmPermisos";
            this.Load += new System.EventHandler(this.frmPermisos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnN;
        private System.Windows.Forms.Button btnNT;
        private System.Windows.Forms.Button btnV;
        private System.Windows.Forms.Button btnVT;
        private System.Windows.Forms.ComboBox cboUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ltbPermisosN;
        private System.Windows.Forms.ListBox ltbPermisosV;
    }
}