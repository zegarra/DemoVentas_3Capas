
namespace ProyVentas_GUI
{
    partial class frmGraficosEstadisticos
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.dtgVentasAnuales = new System.Windows.Forms.DataGridView();
            this.Grafico1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Grafico2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVentasAnuales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grafico1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grafico2)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgVentasAnuales
            // 
            this.dtgVentasAnuales.AllowUserToAddRows = false;
            this.dtgVentasAnuales.AllowUserToDeleteRows = false;
            this.dtgVentasAnuales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgVentasAnuales.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dtgVentasAnuales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVentasAnuales.Location = new System.Drawing.Point(222, 46);
            this.dtgVentasAnuales.Name = "dtgVentasAnuales";
            this.dtgVentasAnuales.ReadOnly = true;
            this.dtgVentasAnuales.RowHeadersVisible = false;
            this.dtgVentasAnuales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgVentasAnuales.Size = new System.Drawing.Size(417, 150);
            this.dtgVentasAnuales.TabIndex = 0;
            // 
            // Grafico1
            // 
            chartArea1.Name = "ChartArea1";
            this.Grafico1.ChartAreas.Add(chartArea1);
            this.Grafico1.Location = new System.Drawing.Point(39, 233);
            this.Grafico1.Name = "Grafico1";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.Grafico1.Series.Add(series1);
            this.Grafico1.Size = new System.Drawing.Size(376, 187);
            this.Grafico1.TabIndex = 1;
            this.Grafico1.Text = "chart1";
            title1.BackColor = System.Drawing.Color.Teal;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.White;
            title1.Name = "Año";
            title1.Text = "Ventas por Año";
            this.Grafico1.Titles.Add(title1);
            // 
            // Grafico2
            // 
            chartArea2.Name = "ChartArea1";
            this.Grafico2.ChartAreas.Add(chartArea2);
            this.Grafico2.Location = new System.Drawing.Point(437, 233);
            this.Grafico2.Name = "Grafico2";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            this.Grafico2.Series.Add(series2);
            this.Grafico2.Size = new System.Drawing.Size(376, 187);
            this.Grafico2.TabIndex = 2;
            this.Grafico2.Text = "chart2";
            title2.BackColor = System.Drawing.Color.DeepPink;
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.ForeColor = System.Drawing.Color.White;
            title2.Name = "Title1";
            title2.Text = "Cantidad facturas año";
            this.Grafico2.Titles.Add(title2);
            // 
            // frmGraficosEstadisticos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 439);
            this.Controls.Add(this.Grafico2);
            this.Controls.Add(this.Grafico1);
            this.Controls.Add(this.dtgVentasAnuales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGraficosEstadisticos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graficos Estadisticos";
            ((System.ComponentModel.ISupportInitialize)(this.dtgVentasAnuales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grafico1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grafico2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgVentasAnuales;
        private System.Windows.Forms.DataVisualization.Charting.Chart Grafico1;
        private System.Windows.Forms.DataVisualization.Charting.Chart Grafico2;
    }
}