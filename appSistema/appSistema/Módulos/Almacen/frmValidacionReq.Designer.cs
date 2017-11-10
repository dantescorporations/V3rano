namespace appSistema
{
    partial class frmValidacionReq
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstvReqA = new System.Windows.Forms.ListView();
            this.NoReq = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.unidadmed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.solicit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fechaPed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fechaEnt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstvReqNA = new System.Windows.Forms.ListView();
            this.Req = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.producto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.unidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.solicitante = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fechaP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fechaE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lstvReqA);
            this.groupBox2.Location = new System.Drawing.Point(12, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(894, 197);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Autorizadas:";
            // 
            // lstvReqA
            // 
            this.lstvReqA.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NoReq,
            this.prod,
            this.cant,
            this.unidadmed,
            this.solicit,
            this.fechaPed,
            this.fechaEnt});
            this.lstvReqA.FullRowSelect = true;
            this.lstvReqA.GridLines = true;
            this.lstvReqA.Location = new System.Drawing.Point(44, 24);
            this.lstvReqA.Name = "lstvReqA";
            this.lstvReqA.Size = new System.Drawing.Size(817, 146);
            this.lstvReqA.TabIndex = 25;
            this.lstvReqA.UseCompatibleStateImageBehavior = false;
            this.lstvReqA.View = System.Windows.Forms.View.Details;
            // 
            // NoReq
            // 
            this.NoReq.Text = "No. Requisición";
            this.NoReq.Width = 89;
            // 
            // prod
            // 
            this.prod.Text = "Producto";
            this.prod.Width = 131;
            // 
            // cant
            // 
            this.cant.Text = "Cantidad";
            this.cant.Width = 114;
            // 
            // unidadmed
            // 
            this.unidadmed.Text = "Unidad de Medida";
            this.unidadmed.Width = 131;
            // 
            // solicit
            // 
            this.solicit.Text = "Solicitante";
            this.solicit.Width = 145;
            // 
            // fechaPed
            // 
            this.fechaPed.Text = "Fecha de Pedido";
            this.fechaPed.Width = 99;
            // 
            // fechaEnt
            // 
            this.fechaEnt.Text = "Fecha de Entrega";
            this.fechaEnt.Width = 102;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstvReqNA);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(894, 197);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "No Autorizadas:";
            // 
            // lstvReqNA
            // 
            this.lstvReqNA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstvReqNA.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Req,
            this.producto,
            this.cantidad,
            this.unidad,
            this.solicitante,
            this.fechaP,
            this.fechaE});
            this.lstvReqNA.FullRowSelect = true;
            this.lstvReqNA.GridLines = true;
            this.lstvReqNA.Location = new System.Drawing.Point(44, 24);
            this.lstvReqNA.Name = "lstvReqNA";
            this.lstvReqNA.Size = new System.Drawing.Size(817, 146);
            this.lstvReqNA.TabIndex = 25;
            this.lstvReqNA.UseCompatibleStateImageBehavior = false;
            this.lstvReqNA.View = System.Windows.Forms.View.Details;
            this.lstvReqNA.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstvReqNA_MouseDoubleClick);
            // 
            // Req
            // 
            this.Req.Text = "No. Requisición";
            this.Req.Width = 87;
            // 
            // producto
            // 
            this.producto.Text = "Producto";
            this.producto.Width = 128;
            // 
            // cantidad
            // 
            this.cantidad.Text = "Cantidad";
            this.cantidad.Width = 111;
            // 
            // unidad
            // 
            this.unidad.Text = "UnidadMedida";
            this.unidad.Width = 129;
            // 
            // solicitante
            // 
            this.solicitante.Text = "Solicitante";
            this.solicitante.Width = 144;
            // 
            // fechaP
            // 
            this.fechaP.Text = "Fecha de Pedido";
            this.fechaP.Width = 106;
            // 
            // fechaE
            // 
            this.fechaE.Text = "Fecha de Entrega";
            this.fechaE.Width = 106;
            // 
            // frmValidacionReq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(928, 438);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmValidacionReq";
            this.Text = "Validación Requisición";
            this.Load += new System.EventHandler(this.frmValidacionReq_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lstvReqA;
        private System.Windows.Forms.ColumnHeader NoReq;
        private System.Windows.Forms.ColumnHeader prod;
        private System.Windows.Forms.ColumnHeader cant;
        private System.Windows.Forms.ColumnHeader unidadmed;
        private System.Windows.Forms.ColumnHeader solicit;
        private System.Windows.Forms.ColumnHeader fechaPed;
        private System.Windows.Forms.ColumnHeader fechaEnt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lstvReqNA;
        private System.Windows.Forms.ColumnHeader Req;
        private System.Windows.Forms.ColumnHeader producto;
        private System.Windows.Forms.ColumnHeader cantidad;
        private System.Windows.Forms.ColumnHeader unidad;
        private System.Windows.Forms.ColumnHeader solicitante;
        private System.Windows.Forms.ColumnHeader fechaP;
        private System.Windows.Forms.ColumnHeader fechaE;

    }
}