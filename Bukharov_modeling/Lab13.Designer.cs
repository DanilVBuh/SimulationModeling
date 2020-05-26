namespace Bukharov_modeling
{
	partial class Lab13
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
			this.probValue = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.startBtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.probValue)).BeginInit();
			this.SuspendLayout();
			// 
			// probValue
			// 
			this.probValue.DecimalPlaces = 4;
			this.probValue.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
			this.probValue.Location = new System.Drawing.Point(91, 12);
			this.probValue.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            262144});
			this.probValue.Name = "probValue";
			this.probValue.Size = new System.Drawing.Size(68, 20);
			this.probValue.TabIndex = 13;
			this.probValue.Value = new decimal(new int[] {
            4,
            0,
            0,
            65536});
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(50, 14);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(29, 13);
			this.label4.TabIndex = 12;
			this.label4.Text = "Prob";
			// 
			// startBtn
			// 
			this.startBtn.Location = new System.Drawing.Point(53, 61);
			this.startBtn.Name = "startBtn";
			this.startBtn.Size = new System.Drawing.Size(106, 23);
			this.startBtn.TabIndex = 14;
			this.startBtn.Text = "Start";
			this.startBtn.UseVisualStyleBackColor = true;
			this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
			// 
			// Lab13
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(218, 110);
			this.Controls.Add(this.startBtn);
			this.Controls.Add(this.probValue);
			this.Controls.Add(this.label4);
			this.Name = "Lab13";
			this.Text = "Lab13";
			((System.ComponentModel.ISupportInitialize)(this.probValue)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NumericUpDown probValue;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button startBtn;
	}
}