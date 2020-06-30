namespace Bukharov_modeling
{
    partial class Lab17
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.startBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.timeValue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.varianceError = new System.Windows.Forms.Label();
            this.averageError = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chi = new System.Windows.Forms.Label();
            this.averageValue = new System.Windows.Forms.Label();
            this.varianceValue = new System.Windows.Forms.Label();
            this.statBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Default;
            this.chart1.Dock = System.Windows.Forms.DockStyle.Top;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Color = System.Drawing.Color.Teal;
            series1.Legend = "Legend1";
            series1.LegendText = "lambda1";
            series1.MarkerSize = 6;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Series1";
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Color = System.Drawing.Color.Green;
            series2.Legend = "Legend1";
            series2.LegendText = "lambda2";
            series2.MarkerSize = 6;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "Series2";
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.Color = System.Drawing.Color.MediumBlue;
            series3.Legend = "Legend1";
            series3.LegendText = "lambda1 + lambda2";
            series3.MarkerSize = 6;
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series3.Name = "Series3";
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(800, 258);
            this.chart1.TabIndex = 17;
            this.chart1.Text = "chart1";
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(12, 415);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(118, 23);
            this.startBtn.TabIndex = 16;
            this.startBtn.Text = "Reload";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(595, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Time: ";
            // 
            // timeValue
            // 
            this.timeValue.AutoSize = true;
            this.timeValue.Location = new System.Drawing.Point(634, 329);
            this.timeValue.Name = "timeValue";
            this.timeValue.Size = new System.Drawing.Size(14, 13);
            this.timeValue.TabIndex = 33;
            this.timeValue.Text = "T";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(595, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Chi-squared: ";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(595, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Average: ";
            // 
            // varianceError
            // 
            this.varianceError.AutoSize = true;
            this.varianceError.Location = new System.Drawing.Point(719, 286);
            this.varianceError.Name = "varianceError";
            this.varianceError.Size = new System.Drawing.Size(26, 13);
            this.varianceError.TabIndex = 27;
            this.varianceError.Text = "Verr";
            // 
            // averageError
            // 
            this.averageError.AutoSize = true;
            this.averageError.Location = new System.Drawing.Point(719, 269);
            this.averageError.Name = "averageError";
            this.averageError.Size = new System.Drawing.Size(26, 13);
            this.averageError.TabIndex = 26;
            this.averageError.Text = "Aerr";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(595, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Variance: ";
            // 
            // chi
            // 
            this.chi.AutoSize = true;
            this.chi.Location = new System.Drawing.Point(668, 312);
            this.chi.Name = "chi";
            this.chi.Size = new System.Drawing.Size(14, 13);
            this.chi.TabIndex = 31;
            this.chi.Text = "X";
            // 
            // averageValue
            // 
            this.averageValue.AutoSize = true;
            this.averageValue.Location = new System.Drawing.Point(654, 269);
            this.averageValue.Name = "averageValue";
            this.averageValue.Size = new System.Drawing.Size(28, 13);
            this.averageValue.TabIndex = 28;
            this.averageValue.Text = "Aval";
            // 
            // varianceValue
            // 
            this.varianceValue.AutoSize = true;
            this.varianceValue.Location = new System.Drawing.Point(654, 286);
            this.varianceValue.Name = "varianceValue";
            this.varianceValue.Size = new System.Drawing.Size(28, 13);
            this.varianceValue.TabIndex = 29;
            this.varianceValue.Text = "Vval";
            // 
            // statBtn
            // 
            this.statBtn.Location = new System.Drawing.Point(670, 415);
            this.statBtn.Name = "statBtn";
            this.statBtn.Size = new System.Drawing.Size(118, 23);
            this.statBtn.TabIndex = 34;
            this.statBtn.Text = "Stat";
            this.statBtn.UseVisualStyleBackColor = true;
            this.statBtn.Click += new System.EventHandler(this.statBtn_Click);
            // 
            // Lab17
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.timeValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.varianceError);
            this.Controls.Add(this.averageError);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chi);
            this.Controls.Add(this.averageValue);
            this.Controls.Add(this.varianceValue);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.startBtn);
            this.Name = "Lab17";
            this.Text = "Lab17";
            this.Load += new System.EventHandler(this.Lab17_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label timeValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label varianceError;
        private System.Windows.Forms.Label averageError;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label chi;
        private System.Windows.Forms.Label averageValue;
        private System.Windows.Forms.Label varianceValue;
        private System.Windows.Forms.Button statBtn;
    }
}