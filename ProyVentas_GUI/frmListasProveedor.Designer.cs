
namespace ProyVentas_GUI
{
    partial class frmListasProveedor
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
            this.btnListarProveedores = new System.Windows.Forms.Button();
            this.btnListarFacturas = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.bkgDatos = new System.ComponentModel.BackgroundWorker();
            this.prgBar = new System.Windows.Forms.ProgressBar();
            this.pcbImagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListarProveedores
            // 
            this.btnListarProveedores.Location = new System.Drawing.Point(150, 27);
            this.btnListarProveedores.Name = "btnListarProveedores";
            this.btnListarProveedores.Size = new System.Drawing.Size(107, 42);
            this.btnListarProveedores.TabIndex = 0;
            this.btnListarProveedores.Text = "Listar Proveedores";
            this.btnListarProveedores.UseVisualStyleBackColor = true;
            this.btnListarProveedores.Click += new System.EventHandler(this.btnListarProveedores_Click);
            // 
            // btnListarFacturas
            // 
            this.btnListarFacturas.Location = new System.Drawing.Point(150, 89);
            this.btnListarFacturas.Name = "btnListarFacturas";
            this.btnListarFacturas.Size = new System.Drawing.Size(107, 42);
            this.btnListarFacturas.TabIndex = 1;
            this.btnListarFacturas.Text = "Listar Facturas";
            this.btnListarFacturas.UseVisualStyleBackColor = true;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(167, 154);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(93, 13);
            this.lblMensaje.TabIndex = 3;
            this.lblMensaje.Text = "Cargando Datos...";
            // 
            // bkgDatos
            // 
            this.bkgDatos.WorkerReportsProgress = true;
            // 
            // prgBar
            // 
            this.prgBar.Location = new System.Drawing.Point(141, 189);
            this.prgBar.Name = "prgBar";
            this.prgBar.Size = new System.Drawing.Size(132, 23);
            this.prgBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgBar.TabIndex = 4;
            // 
            // pcbImagen
            // 
            this.pcbImagen.Image = global::ProyVentas_GUI.Properties.Resources.indicator;
            this.pcbImagen.Location = new System.Drawing.Point(150, 154);
            this.pcbImagen.Name = "pcbImagen";
            this.pcbImagen.Size = new System.Drawing.Size(20, 20);
            this.pcbImagen.TabIndex = 2;
            this.pcbImagen.TabStop = false;
            // 
            // frmListasProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 224);
            this.Controls.Add(this.prgBar);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.pcbImagen);
            this.Controls.Add(this.btnListarFacturas);
            this.Controls.Add(this.btnListarProveedores);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListasProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListasProveedor";
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListarProveedores;
        private System.Windows.Forms.Button btnListarFacturas;
        private System.Windows.Forms.PictureBox pcbImagen;
        private System.Windows.Forms.Label lblMensaje;
        private System.ComponentModel.BackgroundWorker bkgDatos;
        private System.Windows.Forms.ProgressBar prgBar;
    }
}