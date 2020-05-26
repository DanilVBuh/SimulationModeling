namespace Bukharov_modeling
{
	partial class Lab11
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
			this.prob1 = new System.Windows.Forms.NumericUpDown();
			this.panel1 = new System.Windows.Forms.Panel();
			this.startBtn = new System.Windows.Forms.Button();
			this.prob5 = new System.Windows.Forms.NumericUpDown();
			this.prob4 = new System.Windows.Forms.NumericUpDown();
			this.prob3 = new System.Windows.Forms.NumericUpDown();
			this.prob2 = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.varianceValue = new System.Windows.Forms.Label();
			this.averageValue = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.prob1)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.prob5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.prob4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.prob3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.prob2)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 5);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Prob 1";
			// 
			// prob1
			// 
			this.prob1.DecimalPlaces = 4;
			this.prob1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
			this.prob1.Location = new System.Drawing.Point(44, 3);
			this.prob1.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            262144});
			this.prob1.Name = "prob1";
			this.prob1.Size = new System.Drawing.Size(68, 20);
			this.prob1.TabIndex = 1;
			this.prob1.Value = new decimal(new int[] {
            15,
            0,
            0,
            131072});
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.varianceValue);
			this.panel1.Controls.Add(this.averageValue);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.startBtn);
			this.panel1.Controls.Add(this.prob5);
			this.panel1.Controls.Add(this.prob4);
			this.panel1.Controls.Add(this.prob3);
			this.panel1.Controls.Add(this.prob2);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.prob1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(190, 237);
			this.panel1.TabIndex = 7;
			// 
			// startBtn
			// 
			this.startBtn.Location = new System.Drawing.Point(6, 133);
			this.startBtn.Name = "startBtn";
			this.startBtn.Size = new System.Drawing.Size(106, 23);
			this.startBtn.TabIndex = 13;
			this.startBtn.Text = "Start";
			this.startBtn.UseVisualStyleBackColor = true;
			this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
			// 
			// prob5
			// 
			this.prob5.DecimalPlaces = 4;
			this.prob5.Enabled = false;
			this.prob5.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
			this.prob5.Location = new System.Drawing.Point(44, 107);
			this.prob5.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            262144});
			this.prob5.Name = "prob5";
			this.prob5.Size = new System.Drawing.Size(68, 20);
			this.prob5.TabIndex = 12;
			// 
			// prob4
			// 
			this.prob4.DecimalPlaces = 4;
			this.prob4.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
			this.prob4.Location = new System.Drawing.Point(44, 81);
			this.prob4.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            262144});
			this.prob4.Name = "prob4";
			this.prob4.Size = new System.Drawing.Size(68, 20);
			this.prob4.TabIndex = 11;
			this.prob4.Value = new decimal(new int[] {
            3,
            0,
            0,
            65536});
			// 
			// prob3
			// 
			this.prob3.DecimalPlaces = 4;
			this.prob3.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
			this.prob3.Location = new System.Drawing.Point(44, 55);
			this.prob3.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            262144});
			this.prob3.Name = "prob3";
			this.prob3.Size = new System.Drawing.Size(68, 20);
			this.prob3.TabIndex = 10;
			this.prob3.Value = new decimal(new int[] {
            25,
            0,
            0,
            131072});
			// 
			// prob2
			// 
			this.prob2.DecimalPlaces = 4;
			this.prob2.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
			this.prob2.Location = new System.Drawing.Point(44, 29);
			this.prob2.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            262144});
			this.prob2.Name = "prob2";
			this.prob2.Size = new System.Drawing.Size(68, 20);
			this.prob2.TabIndex = 9;
			this.prob2.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(3, 109);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(38, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "Prob 5";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 83);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(38, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Prob 4";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 57);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(38, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Prob 3";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 31);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Prob 2";
			// 
			// varianceValue
			// 
			this.varianceValue.AutoSize = true;
			this.varianceValue.Location = new System.Drawing.Point(62, 185);
			this.varianceValue.Name = "varianceValue";
			this.varianceValue.Size = new System.Drawing.Size(0, 10);
			this.varianceValue.TabIndex = 22;
			// 
			// averageValue
			// 
			this.averageValue.AutoSize = true;
			this.averageValue.Location = new System.Drawing.Point(62, 159);
			this.averageValue.Name = "averageValue";
			this.averageValue.Size = new System.Drawing.Size(0, 10);
			this.averageValue.TabIndex = 21;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(3, 185);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(53, 17);
			this.label6.TabIndex = 20;
			this.label6.Text = "Variance: ";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(3, 159);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(53, 17);
			this.label7.TabIndex = 19;
			this.label7.Text = "Average: ";
			// 
			// Lab11
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(190, 237);
			this.Controls.Add(this.panel1);
			this.Name = "Lab11";
			this.Text = "Lab11";
			((System.ComponentModel.ISupportInitialize)(this.prob1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.prob5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.prob4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.prob3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.prob2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown prob1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button startBtn;
		private System.Windows.Forms.NumericUpDown prob5;
		private System.Windows.Forms.NumericUpDown prob4;
		private System.Windows.Forms.NumericUpDown prob3;
		private System.Windows.Forms.NumericUpDown prob2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label varianceValue;
		private System.Windows.Forms.Label averageValue;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
	}
}