namespace Taller_2.Displays
{
    partial class Statistics
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblEstadisticas = new System.Windows.Forms.Label();
            this.chartProductos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEstadisticas
            // 
            this.lblEstadisticas.AutoSize = true;
            this.lblEstadisticas.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadisticas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEstadisticas.Location = new System.Drawing.Point(184, 33);
            this.lblEstadisticas.Name = "lblEstadisticas";
            this.lblEstadisticas.Size = new System.Drawing.Size(205, 39);
            this.lblEstadisticas.TabIndex = 0;
            this.lblEstadisticas.Text = "Estadisticas";
            // 
            // chartProductos
            // 
            chartArea1.Name = "ChartArea1";
            this.chartProductos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartProductos.Legends.Add(legend1);
            this.chartProductos.Location = new System.Drawing.Point(131, 135);
            this.chartProductos.Name = "chartProductos";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartProductos.Series.Add(series1);
            this.chartProductos.Size = new System.Drawing.Size(325, 250);
            this.chartProductos.TabIndex = 1;
            this.chartProductos.Text = "chart1";
            this.chartProductos.Click += new System.EventHandler(this.chartProductos_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(26, 625);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Inventario";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(6)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(590, 660);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.chartProductos);
            this.Controls.Add(this.lblEstadisticas);
            this.Name = "Statistics";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEstadisticas;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProductos;
        private System.Windows.Forms.Button button3;
    }
}