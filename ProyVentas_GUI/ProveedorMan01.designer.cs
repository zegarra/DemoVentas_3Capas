namespace ProyVentas_GUI
{
    partial class ProveedorMan01
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.dtgProveedor = new System.Windows.Forms.DataGridView();
            this.Cod_prv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Raz_soc_prv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dir_prv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel_prv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ruc_prv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRegistros = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(1003, 442);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(922, 442);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 6;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsertar.Location = new System.Drawing.Point(841, 442);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 3;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // dtgProveedor
            // 
            this.dtgProveedor.AllowUserToAddRows = false;
            this.dtgProveedor.AllowUserToDeleteRows = false;
            this.dtgProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgProveedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProveedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod_prv,
            this.Raz_soc_prv,
            this.Dir_prv,
            this.Tel_prv,
            this.Ruc_prv,
            this.Departamento,
            this.Provincia,
            this.Distrito,
            this.Estado});
            this.dtgProveedor.Location = new System.Drawing.Point(12, 62);
            this.dtgProveedor.Name = "dtgProveedor";
            this.dtgProveedor.ReadOnly = true;
            this.dtgProveedor.RowHeadersVisible = false;
            this.dtgProveedor.RowTemplate.Height = 24;
            this.dtgProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProveedor.Size = new System.Drawing.Size(1077, 337);
            this.dtgProveedor.TabIndex = 2;
            this.dtgProveedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProveedor_CellContentClick);
            this.dtgProveedor.DoubleClick += new System.EventHandler(this.dtgProveedor_DoubleClick);
            // 
            // Cod_prv
            // 
            this.Cod_prv.DataPropertyName = "Cod_prv";
            this.Cod_prv.HeaderText = "Cod. Proveedor";
            this.Cod_prv.Name = "Cod_prv";
            this.Cod_prv.ReadOnly = true;
            // 
            // Raz_soc_prv
            // 
            this.Raz_soc_prv.DataPropertyName = "Raz_soc_prv";
            this.Raz_soc_prv.HeaderText = "Razón Social";
            this.Raz_soc_prv.Name = "Raz_soc_prv";
            this.Raz_soc_prv.ReadOnly = true;
            // 
            // Dir_prv
            // 
            this.Dir_prv.DataPropertyName = "Dir_prv";
            this.Dir_prv.HeaderText = "Dirección";
            this.Dir_prv.Name = "Dir_prv";
            this.Dir_prv.ReadOnly = true;
            // 
            // Tel_prv
            // 
            this.Tel_prv.DataPropertyName = "Tel_prv";
            this.Tel_prv.HeaderText = "Teléfono";
            this.Tel_prv.Name = "Tel_prv";
            this.Tel_prv.ReadOnly = true;
            // 
            // Ruc_prv
            // 
            this.Ruc_prv.DataPropertyName = "Ruc_prv";
            this.Ruc_prv.HeaderText = "RUC";
            this.Ruc_prv.Name = "Ruc_prv";
            this.Ruc_prv.ReadOnly = true;
            // 
            // Departamento
            // 
            this.Departamento.DataPropertyName = "Departamento";
            this.Departamento.HeaderText = "Departamento";
            this.Departamento.Name = "Departamento";
            this.Departamento.ReadOnly = true;
            // 
            // Provincia
            // 
            this.Provincia.DataPropertyName = "Provincia";
            this.Provincia.HeaderText = "Provincia";
            this.Provincia.Name = "Provincia";
            this.Provincia.ReadOnly = true;
            // 
            // Distrito
            // 
            this.Distrito.DataPropertyName = "Distrito";
            this.Distrito.HeaderText = "Distrito";
            this.Distrito.Name = "Distrito";
            this.Distrito.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ingrese iniciales de razon social:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(205, 20);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(283, 20);
            this.txtFiltro.TabIndex = 8;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(961, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Registros:";
            // 
            // lblRegistros
            // 
            this.lblRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegistros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRegistros.Location = new System.Drawing.Point(1035, 402);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(54, 23);
            this.lblRegistros.TabIndex = 7;
            // 
            // ProveedorMan01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 468);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.dtgProveedor);
            this.Name = "ProveedorMan01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Proveedores";
            this.Load += new System.EventHandler(this.ProveedorMan01_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProveedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.DataGridView dtgProveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_prv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Raz_soc_prv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dir_prv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel_prv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ruc_prv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Provincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}