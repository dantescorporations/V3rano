namespace appSistema
{
    partial class frmCPostales
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cboEstados = new System.Windows.Forms.ComboBox();
            this.cboMunicipios = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboColonias = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Controls.Add(this.cboEstados);
            this.groupBox2.Controls.Add(this.cboMunicipios);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cboColonias);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblCP);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(17, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 201);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(162, 159);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cboEstados
            // 
            this.cboEstados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstados.FormattingEnabled = true;
            this.cboEstados.Location = new System.Drawing.Point(69, 28);
            this.cboEstados.Name = "cboEstados";
            this.cboEstados.Size = new System.Drawing.Size(168, 21);
            this.cboEstados.TabIndex = 7;
            this.cboEstados.SelectedIndexChanged += new System.EventHandler(this.cboEstados_SelectedIndexChanged);
            // 
            // cboMunicipios
            // 
            this.cboMunicipios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMunicipios.FormattingEnabled = true;
            this.cboMunicipios.Location = new System.Drawing.Point(69, 71);
            this.cboMunicipios.Name = "cboMunicipios";
            this.cboMunicipios.Size = new System.Drawing.Size(168, 21);
            this.cboMunicipios.TabIndex = 8;
            this.cboMunicipios.SelectedIndexChanged += new System.EventHandler(this.cboMunicipios_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Colonias";
            // 
            // cboColonias
            // 
            this.cboColonias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboColonias.FormattingEnabled = true;
            this.cboColonias.Location = new System.Drawing.Point(69, 109);
            this.cboColonias.Name = "cboColonias";
            this.cboColonias.Size = new System.Drawing.Size(168, 21);
            this.cboColonias.TabIndex = 9;
            this.cboColonias.SelectedIndexChanged += new System.EventHandler(this.cboColonias_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Municipios";
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Location = new System.Drawing.Point(66, 164);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(28, 13);
            this.lblCP.TabIndex = 10;
            this.lblCP.Text = "CP#";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Estados";
            // 
            // frmCPostales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmCPostales";
            this.Text = "frmCPostales";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cboEstados;
        private System.Windows.Forms.ComboBox cboMunicipios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboColonias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.Label label1;
    }
}