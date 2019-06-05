namespace SolveTestApp
{
    partial class FunctionChartForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.functionChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.functionChart)).BeginInit();
            this.SuspendLayout();
            // 
            // functionChart
            // 
            chartArea3.Name = "ChartArea1";
            this.functionChart.ChartAreas.Add(chartArea3);
            this.functionChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.functionChart.Legends.Add(legend3);
            this.functionChart.Location = new System.Drawing.Point(0, 0);
            this.functionChart.Margin = new System.Windows.Forms.Padding(2);
            this.functionChart.Name = "functionChart";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series2";
            this.functionChart.Series.Add(series5);
            this.functionChart.Series.Add(series6);
            this.functionChart.Size = new System.Drawing.Size(800, 450);
            this.functionChart.TabIndex = 1;
            this.functionChart.Text = "График";
            // 
            // FunctionChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.functionChart);
            this.Name = "FunctionChartForm";
            this.Text = "График";
            ((System.ComponentModel.ISupportInitialize)(this.functionChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart functionChart;
    }
}