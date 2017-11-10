namespace appSistema
{
    partial class frmEstatusCompras
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnComparar = new System.Windows.Forms.Button();
            this.btnRastrear = new System.Windows.Forms.Button();
            this.lstvConcentrado = new System.Windows.Forms.ListView();
            this.Filtro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.solicitud = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.entrega = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.oc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fact = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.env = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnComparar
            // 
            this.btnComparar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnComparar.Location = new System.Drawing.Point(543, 340);
            this.btnComparar.Name = "btnComparar";
            this.btnComparar.Size = new System.Drawing.Size(80, 25);
            this.btnComparar.TabIndex = 22;
            this.btnComparar.Text = "Comparar";
            this.btnComparar.UseVisualStyleBackColor = true;
            // 
            // btnRastrear
            // 
            this.btnRastrear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRastrear.Location = new System.Drawing.Point(434, 340);
            this.btnRastrear.Name = "btnRastrear";
            this.btnRastrear.Size = new System.Drawing.Size(90, 25);
            this.btnRastrear.TabIndex = 21;
            this.btnRastrear.Text = "Rastrear";
            this.btnRastrear.UseVisualStyleBackColor = true;
            this.btnRastrear.Click += new System.EventHandler(this.btnRastrear_Click);
            // 
            // lstvConcentrado
            // 
            this.lstvConcentrado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstvConcentrado.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Filtro,
            this.solicitud,
            this.entrega,
            this.oc,
            this.fact,
            this.env});
            this.lstvConcentrado.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.lstvConcentrado.GridLines = true;
            this.lstvConcentrado.Location = new System.Drawing.Point(12, 21);
            this.lstvConcentrado.Name = "lstvConcentrado";
            this.lstvConcentrado.Size = new System.Drawing.Size(632, 282);
            this.lstvConcentrado.TabIndex = 26;
            this.lstvConcentrado.UseCompatibleStateImageBehavior = false;
            this.lstvConcentrado.View = System.Windows.Forms.View.Details;
            // 
            // Filtro
            // 
            this.Filtro.Text = "Filtro";
            this.Filtro.Width = 189;
            // 
            // solicitud
            // 
            this.solicitud.Text = "Solicitud Requisición";
            this.solicitud.Width = 114;
            // 
            // entrega
            // 
            this.entrega.Text = "Entrega Cotización";
            this.entrega.Width = 109;
            // 
            // oc
            // 
            this.oc.Text = "Orden Compra";
            this.oc.Width = 85;
            // 
            // fact
            // 
            this.fact.Text = "Facturación";
            this.fact.Width = 71;
            // 
            // env
            // 
            this.env.Text = "Envío";
            // 
            // frmEstatusCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(656, 377);
            this.Controls.Add(this.lstvConcentrado);
            this.Controls.Add(this.btnComparar);
            this.Controls.Add(this.btnRastrear);
            this.Name = "frmEstatusCompras";
            this.Text = "Estatus de Compras";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnComparar;
        private System.Windows.Forms.Button btnRastrear;
        private System.Windows.Forms.ListView lstvConcentrado;
        private System.Windows.Forms.ColumnHeader Filtro;
        private System.Windows.Forms.ColumnHeader solicitud;
        private System.Windows.Forms.ColumnHeader entrega;
        private System.Windows.Forms.ColumnHeader oc;
        private System.Windows.Forms.ColumnHeader fact;
        private System.Windows.Forms.ColumnHeader env;
    }
}