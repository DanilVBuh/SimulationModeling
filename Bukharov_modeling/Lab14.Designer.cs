namespace Bukharov_modeling
{
	partial class Lab14
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
			this.label1 = new System.Windows.Forms.Label();
			this.averageValue = new System.Windows.Forms.NumericUpDown();
			this.panel1 = new System.Windows.Forms.Panel();
			this.startBtn = new System.Windows.Forms.Button();
			this.varianceValue = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.numberValue = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.averageValue)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.varianceValue)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numberValue)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Average";
			// 
			// averageValue
			// 
			this.averageValue.DecimalPlaces = 3;
			this.averageValue.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
			this.averageValue.Location = new System.Drawing.Point(56, 7);
			this.averageValue.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.averageValue.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
			this.averageValue.Name = "averageValue";
			this.averageValue.Size = new System.Drawing.Size(68, 20);
			this.averageValue.TabIndex = 1;
			this.averageValue.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.numberValue);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.startBtn);
			this.panel1.Controls.Add(this.varianceValue);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.averageValue);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(214, 117);
			this.panel1.TabIndex = 8;
			// 
			// startBtn
			// 
			this.startBtn.Location = new System.Drawing.Point(6, 85);
			this.startBtn.Name = "startBtn";
			this.startBtn.Size = new System.Drawing.Size(118, 23);
			this.startBtn.TabIndex = 13;
			this.startBtn.Text = "Start";
			this.startBtn.UseVisualStyleBackColor = true;
			this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
			// 
			// varianceValue
			// 
			this.varianceValue.DecimalPlaces = 3;
			this.varianceValue.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
			this.varianceValue.Location = new System.Drawing.Point(56, 33);
			this.varianceValue.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.varianceValue.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
			this.varianceValue.Name = "varianceValue";
			this.varianceValue.Size = new System.Drawing.Size(68, 20);
			this.varianceValue.TabIndex = 9;
			this.varianceValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Variance";
			// 
			// numberValue
			// 
			this.numberValue.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.numberValue.Location = new System.Drawing.Point(56, 59);
			this.numberValue.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
			this.numberValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numberValue.Name = "numberValue";
			this.numberValue.Size = new System.Drawing.Size(68, 20);
			this.numberValue.TabIndex = 15;
			this.numberValue.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 61);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 13);
			this.label3.TabIndex = 14;
			this.label3.Text = "Number";
			// 
			// Lab14
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(214, 117);
			this.Controls.Add(this.panel1);
			this.Name = "Lab14";
			this.Text = "Lab14";
			((System.ComponentModel.ISupportInitialize)(this.averageValue)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.varianceValue)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numberValue)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown averageValue;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button startBtn;
		private System.Windows.Forms.NumericUpDown varianceValue;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown numberValue;
		private System.Windows.Forms.Label label3;
	}
}