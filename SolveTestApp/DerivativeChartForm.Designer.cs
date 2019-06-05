namespace SolveTestApp
{
    partial class DerivativeChartForm
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.derivativeChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.derivativeChart)).BeginInit();
            this.SuspendLayout();
            // 
            // derivativeChart
            // 
            chartArea1.Name = "ChartArea1";
            this.derivativeChart.ChartAreas.Add(chartArea1);
            this.derivativeChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.derivativeChart.Legends.Add(legend1);
            this.derivativeChart.Location = new System.Drawing.Point(0, 0);
            this.derivativeChart.Margin = new System.Windows.Forms.Padding(2);
            this.derivativeChart.Name = "derivativeChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            this.derivativeChart.Series.Add(series1);
            this.derivativeChart.Series.Add(series2);
            this.derivativeChart.Size = new System.Drawing.Size(600, 366);
            this.derivativeChart.TabIndex = 0;
            this.derivativeChart.Text = "Производная";
            // 
            // DerivativeChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.derivativeChart);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DerivativeChartForm";
            this.Text = "График";
            ((System.ComponentModel.ISupportInitialize)(this.derivativeChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart derivativeChart;
    }
}