namespace WindowsApplication1
{
	partial class Currency
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.SartBtn = new System.Windows.Forms.Button();
			this.DaysText = new System.Windows.Forms.NumericUpDown();
			this.PriceText = new System.Windows.Forms.NumericUpDown();
			this.TimeText = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.label2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.RublesText = new System.Windows.Forms.NumericUpDown();
			this.label8 = new System.Windows.Forms.Label();
			this.EurText = new System.Windows.Forms.Label();
			this.RubText = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.PauseBtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.ExchangePanel = new System.Windows.Forms.Panel();
			this.EuroAmountText = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.BuyBtn = new System.Windows.Forms.Button();
			this.SellBtn = new System.Windows.Forms.Button();
			this.ActualPriceText = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.DaysText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PriceText)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.RublesText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.ExchangePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.EuroAmountText)).BeginInit();
			this.SuspendLayout();
			// 
			// SartBtn
			// 
			this.SartBtn.Location = new System.Drawing.Point(201, 8);
			this.SartBtn.Name = "SartBtn";
			this.SartBtn.Size = new System.Drawing.Size(98, 70);
			this.SartBtn.TabIndex = 2;
			this.SartBtn.Text = "Start";
			this.SartBtn.UseVisualStyleBackColor = true;
			this.SartBtn.Click += new System.EventHandler(this.SartBtn_Click);
			// 
			// DaysText
			// 
			this.DaysText.Location = new System.Drawing.Point(75, 32);
			this.DaysText.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.DaysText.Name = "DaysText";
			this.DaysText.Size = new System.Drawing.Size(120, 20);
			this.DaysText.TabIndex = 1;
			this.DaysText.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// PriceText
			// 
			this.PriceText.DecimalPlaces = 4;
			this.PriceText.Location = new System.Drawing.Point(75, 6);
			this.PriceText.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.PriceText.Name = "PriceText";
			this.PriceText.Size = new System.Drawing.Size(120, 20);
			this.PriceText.TabIndex = 1;
			this.PriceText.Value = new decimal(new int[] {
            71,
            0,
            0,
            0});
			// 
			// TimeText
			// 
			this.TimeText.AutoSize = true;
			this.TimeText.Location = new System.Drawing.Point(341, 13);
			this.TimeText.Name = "TimeText";
			this.TimeText.Size = new System.Drawing.Size(13, 13);
			this.TimeText.TabIndex = 0;
			this.TimeText.Text = "0";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(305, 13);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(30, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Time";
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 34);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(31, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Days";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.ActualPriceText);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.ExchangePanel);
			this.panel1.Controls.Add(this.RublesText);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.EurText);
			this.panel1.Controls.Add(this.RubText);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.PauseBtn);
			this.panel1.Controls.Add(this.SartBtn);
			this.panel1.Controls.Add(this.DaysText);
			this.panel1.Controls.Add(this.PriceText);
			this.panel1.Controls.Add(this.TimeText);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 362);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 88);
			this.panel1.TabIndex = 2;
			// 
			// RublesText
			// 
			this.RublesText.DecimalPlaces = 4;
			this.RublesText.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.RublesText.Location = new System.Drawing.Point(75, 58);
			this.RublesText.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.RublesText.Name = "RublesText";
			this.RublesText.Size = new System.Drawing.Size(120, 20);
			this.RublesText.TabIndex = 6;
			this.RublesText.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(13, 60);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(40, 13);
			this.label8.TabIndex = 5;
			this.label8.Text = "Rubles";
			// 
			// EurText
			// 
			this.EurText.AutoSize = true;
			this.EurText.Location = new System.Drawing.Point(341, 61);
			this.EurText.Name = "EurText";
			this.EurText.Size = new System.Drawing.Size(13, 13);
			this.EurText.TabIndex = 3;
			this.EurText.Text = "0";
			this.EurText.Click += new System.EventHandler(this.label7_Click);
			// 
			// RubText
			// 
			this.RubText.AutoSize = true;
			this.RubText.Location = new System.Drawing.Point(341, 48);
			this.RubText.Name = "RubText";
			this.RubText.Size = new System.Drawing.Size(13, 13);
			this.RubText.TabIndex = 3;
			this.RubText.Text = "0";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(305, 61);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(30, 13);
			this.label6.TabIndex = 4;
			this.label6.Text = "EUR";
			this.label6.Click += new System.EventHandler(this.label6_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(305, 48);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(30, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "RUB";
			// 
			// PauseBtn
			// 
			this.PauseBtn.Location = new System.Drawing.Point(403, 5);
			this.PauseBtn.Name = "PauseBtn";
			this.PauseBtn.Size = new System.Drawing.Size(98, 70);
			this.PauseBtn.TabIndex = 2;
			this.PauseBtn.Text = "Exchange";
			this.PauseBtn.UseVisualStyleBackColor = true;
			this.PauseBtn.Visible = false;
			this.PauseBtn.Click += new System.EventHandler(this.PauseBtn_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Initial price";
			// 
			// chart1
			// 
			chartArea2.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea2);
			this.chart1.Dock = System.Windows.Forms.DockStyle.Top;
			legend2.Enabled = false;
			legend2.Name = "Legend1";
			this.chart1.Legends.Add(legend2);
			this.chart1.Location = new System.Drawing.Point(0, 0);
			this.chart1.Name = "chart1";
			series2.BorderWidth = 4;
			series2.ChartArea = "ChartArea1";
			series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series2.Color = System.Drawing.Color.LawnGreen;
			series2.EmptyPointStyle.CustomProperties = "LabelStyle=Center";
			series2.EmptyPointStyle.LabelBackColor = System.Drawing.Color.Transparent;
			series2.EmptyPointStyle.LabelFormat = "F4";
			series2.LabelFormat = "f4";
			series2.Legend = "Legend1";
			series2.Name = "Series1";
			this.chart1.Series.Add(series2);
			this.chart1.Size = new System.Drawing.Size(800, 362);
			this.chart1.TabIndex = 3;
			this.chart1.Text = "chart1";
			// 
			// ExchangePanel
			// 
			this.ExchangePanel.Controls.Add(this.SellBtn);
			this.ExchangePanel.Controls.Add(this.BuyBtn);
			this.ExchangePanel.Controls.Add(this.label3);
			this.ExchangePanel.Controls.Add(this.EuroAmountText);
			this.ExchangePanel.Location = new System.Drawing.Point(508, 4);
			this.ExchangePanel.Name = "ExchangePanel";
			this.ExchangePanel.Size = new System.Drawing.Size(280, 81);
			this.ExchangePanel.TabIndex = 7;
			// 
			// EuroAmountText
			// 
			this.EuroAmountText.DecimalPlaces = 4;
			this.EuroAmountText.Location = new System.Drawing.Point(39, 26);
			this.EuroAmountText.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.EuroAmountText.Name = "EuroAmountText";
			this.EuroAmountText.Size = new System.Drawing.Size(120, 20);
			this.EuroAmountText.TabIndex = 7;
			this.EuroAmountText.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.EuroAmountText.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 30);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(30, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "EUR";
			// 
			// BuyBtn
			// 
			this.BuyBtn.Location = new System.Drawing.Point(165, 23);
			this.BuyBtn.Name = "BuyBtn";
			this.BuyBtn.Size = new System.Drawing.Size(48, 23);
			this.BuyBtn.TabIndex = 9;
			this.BuyBtn.Text = "Buy";
			this.BuyBtn.UseVisualStyleBackColor = true;
			this.BuyBtn.Click += new System.EventHandler(this.BuyBtn_Click);
			// 
			// SellBtn
			// 
			this.SellBtn.Location = new System.Drawing.Point(219, 23);
			this.SellBtn.Name = "SellBtn";
			this.SellBtn.Size = new System.Drawing.Size(48, 23);
			this.SellBtn.TabIndex = 10;
			this.SellBtn.Text = "Sell";
			this.SellBtn.UseVisualStyleBackColor = true;
			this.SellBtn.Click += new System.EventHandler(this.SellBtn_Click);
			// 
			// ActualPriceText
			// 
			this.ActualPriceText.AutoSize = true;
			this.ActualPriceText.Location = new System.Drawing.Point(341, 26);
			this.ActualPriceText.Name = "ActualPriceText";
			this.ActualPriceText.Size = new System.Drawing.Size(13, 13);
			this.ActualPriceText.TabIndex = 8;
			this.ActualPriceText.Text = "0";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(305, 26);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(31, 13);
			this.label9.TabIndex = 9;
			this.label9.Text = "Price";
			// 
			// Currency
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.chart1);
			this.Name = "Currency";
			this.Text = "Currency";
			((System.ComponentModel.ISupportInitialize)(this.DaysText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PriceText)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.RublesText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.ExchangePanel.ResumeLayout(false);
			this.ExchangePanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.EuroAmountText)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button SartBtn;
		private System.Windows.Forms.NumericUpDown DaysText;
		private System.Windows.Forms.NumericUpDown PriceText;
		private System.Windows.Forms.Label TimeText;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.Button PauseBtn;
		private System.Windows.Forms.Label EurText;
		private System.Windows.Forms.Label RubText;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown RublesText;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Panel ExchangePanel;
		private System.Windows.Forms.NumericUpDown EuroAmountText;
		private System.Windows.Forms.Button SellBtn;
		private System.Windows.Forms.Button BuyBtn;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label ActualPriceText;
		private System.Windows.Forms.Label label9;
	}
}