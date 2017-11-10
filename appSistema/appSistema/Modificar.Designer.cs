namespace appSistema
{
    partial class Modificar
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
            this.txtContraseñaA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContraseña1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContraseña2 = new System.Windows.Forms.TextBox();
            this.lblValidar = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtContraseñaA
            // 
            this.txtContraseñaA.Location = new System.Drawing.Point(32, 68);
            this.txtContraseñaA.Margin = new System.Windows.Forms.Padding(4);
            this.txtContraseñaA.Name = "txtContraseñaA";
            this.txtContraseñaA.PasswordChar = '*';
            this.txtContraseñaA.Size = new System.Drawing.Size(374, 23);
            this.txtContraseñaA.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contraseña Anterior";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAceptar.Location = new System.Drawing.Point(174, 315);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(104, 23);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nueva Contraseña";
            // 
            // txtContraseña1
            // 
            this.txtContraseña1.Location = new System.Drawing.Point(31, 127);
            this.txtContraseña1.Margin = new System.Windows.Forms.Padding(4);
            this.txtContraseña1.Name = "txtContraseña1";
            this.txtContraseña1.PasswordChar = '*';
            this.txtContraseña1.Size = new System.Drawing.Size(374, 23);
            this.txtContraseña1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 170);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Repetir Nueva Contraseña";
            // 
            // txtContraseña2
            // 
            this.txtContraseña2.Location = new System.Drawing.Point(32, 188);
            this.txtContraseña2.Margin = new System.Windows.Forms.Padding(4);
            this.txtContraseña2.Name = "txtContraseña2";
            this.txtContraseña2.PasswordChar = '*';
            this.txtContraseña2.Size = new System.Drawing.Size(374, 23);
            this.txtContraseña2.TabIndex = 5;
            // 
            // lblValidar
            // 
            this.lblValidar.AutoSize = true;
            this.lblValidar.BackColor = System.Drawing.Color.Transparent;
            this.lblValidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidar.Location = new System.Drawing.Point(27, 231);
            this.lblValidar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValidar.Name = "lblValidar";
            this.lblValidar.Size = new System.Drawing.Size(17, 25);
            this.lblValidar.TabIndex = 13;
            this.lblValidar.Text = ".";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtContraseña1);
            this.groupBox1.Controls.Add(this.lblValidar);
            this.groupBox1.Controls.Add(this.txtContraseña2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtContraseñaA);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(21, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 268);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cambiar contraseña";
            // 
            // Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(482, 341);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(498, 380);
            this.MinimumSize = new System.Drawing.Size(498, 380);
            this.Name = "Modificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtContraseñaA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContraseña1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtContraseña2;
        private System.Windows.Forms.Label lblValidar;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}