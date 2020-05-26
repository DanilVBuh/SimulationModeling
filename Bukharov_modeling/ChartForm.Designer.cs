namespace Bukharov_modeling
{
	partial class ChartForm
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.chi = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.reloadBtn = new System.Windows.Forms.Button();
			this.varianceValue = new System.Windows.Forms.Label();
			this.averageValue = new System.Windows.Forms.Label();
			this.varianceError = new System.Windows.Forms.Label();
			this.averageError = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.playBtn = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.playBtn);
			this.panel1.Controls.Add(this.chi);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.reloadBtn);
			this.panel1.Controls.Add(this.varianceValue);
			this.panel1.Controls.Add(this.averageValue);
			this.panel1.Controls.Add(this.varianceError);
			this.panel1.Controls.Add(this.averageError);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.chart1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(329, 283);
			this.panel1.TabIndex = 13;
			// 
			// chi
			// 
			this.chi.AutoSize = true;
			this.chi.Location = new System.Drawing.Point(86, 229);
			this.chi.Name = "chi";
			this.chi.Size = new System.Drawing.Size(14, 13);
			this.chi.TabIndex = 21;
			this.chi.Text = "X";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(13, 229);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 17);
			this.label4.TabIndex = 20;
			this.label4.Text = "Chi-squared: ";
			// 
			// reloadBtn
			// 
			this.reloadBtn.Location = new System.Drawing.Point(242, 184);
			this.reloadBtn.Name = "reloadBtn";
			this.reloadBtn.Size = new System.Drawing.Size(75, 23);
			this.reloadBtn.TabIndex = 19;
			this.reloadBtn.Text = "Reload";
			this.reloadBtn.UseVisualStyleBackColor = true;
			this.reloadBtn.Click += new System.EventHandler(this.reloadBtn_Click);
			// 
			// varianceValue
			// 
			this.varianceValue.AutoSize = true;
			this.varianceValue.Location = new System.Drawing.Point(72, 203);
			this.varianceValue.Name = "varianceValue";
			this.varianceValue.Size = new System.Drawing.Size(28, 13);
			this.varianceValue.TabIndex = 18;
			this.varianceValue.Text = "Vval";
			// 
			// averageValue
			// 
			this.averageValue.AutoSize = true;
			this.averageValue.Location = new System.Drawing.Point(72, 186);
			this.averageValue.Name = "averageValue";
			this.averageValue.Size = new System.Drawing.Size(28, 13);
			this.averageValue.TabIndex = 17;
			this.averageValue.Text = "Aval";
			// 
			// varianceError
			// 
			this.varianceError.AutoSize = true;
			this.varianceError.Location = new System.Drawing.Point(146, 203);
			this.varianceError.Name = "varianceError";
			this.varianceError.Size = new System.Drawing.Size(26, 13);
			this.varianceError.TabIndex = 16;
			this.varianceError.Text = "Verr";
			// 
			// averageError
			// 
			this.averageError.AutoSize = true;
			this.averageError.Location = new System.Drawing.Point(146, 186);
			this.averageError.Name = "averageError";
			this.averageError.Size = new System.Drawing.Size(26, 13);
			this.averageError.TabIndex = 15;
			this.averageError.Text = "Aerr";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 203);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 17);
			this.label2.TabIndex = 10;
			this.label2.Text = "Variance: ";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 186);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 17);
			this.label1.TabIndex = 9;
			this.label1.Text = "Average: ";
			// 
			// chart1
			// 
			chartArea1.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea1);
			this.chart1.Cursor = System.Windows.Forms.Cursors.Default;
			this.chart1.Dock = System.Windows.Forms.DockStyle.Top;
			legend1.Enabled = false;
			legend1.Name = "Legend1";
			this.chart1.Legends.Add(legend1);
			this.chart1.Location = new System.Drawing.Point(0, 0);
			this.chart1.Name = "chart1";
			series1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Percent05;
			series1.BackImageTransparentColor = System.Drawing.Color.White;
			series1.BorderColor = System.Drawing.Color.DarkBlue;
			series1.ChartArea = "ChartArea1";
			series1.IsValueShownAsLabel = true;
			series1.LabelBackColor = System.Drawing.Color.White;
			series1.LabelBorderColor = System.Drawing.Color.Black;
			series1.Legend = "Legend1";
			series1.MarkerBorderColor = System.Drawing.Color.White;
			series1.MarkerColor = System.Drawing.Color.White;
			series1.Name = "Series1";
			series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
			series1.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.Transparent;
			series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
			series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
			series2.ChartArea = "ChartArea1";
			series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
			series2.Legend = "Legend1";
			series2.MarkerColor = System.Drawing.Color.Blue;
			series2.Name = "Series2";
			series2.YValuesPerPoint = 6;
			this.chart1.Series.Add(series1);
			this.chart1.Series.Add(series2);
			this.chart1.Size = new System.Drawing.Size(329, 177);
			this.chart1.TabIndex = 8;
			this.chart1.Text = "chart1";
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// playBtn
			// 
			this.playBtn.Location = new System.Drawing.Point(242, 213);
			this.playBtn.Name = "playBtn";
			this.playBtn.Size = new System.Drawing.Size(75, 23);
			this.playBtn.TabIndex = 22;
			this.playBtn.Text = "Play";
			this.playBtn.UseVisualStyleBackColor = true;
			this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
			// 
			// ChartForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(329, 283);
			this.Controls.Add(this.panel1);
			this.Name = "ChartForm";
			this.Text = "ChartForm";
			this.Load += new System.EventHandler(this.ChartForm_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label varianceError;
		private System.Windows.Forms.Label averageError;
		private System.Windows.Forms.Label varianceValue;
		private System.Windows.Forms.Label averageValue;
		private System.Windows.Forms.Button reloadBtn;
		private System.Windows.Forms.Label chi;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button playBtn;
	}
}