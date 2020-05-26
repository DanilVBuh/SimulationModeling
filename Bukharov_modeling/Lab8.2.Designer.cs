namespace Bukharov_modeling
{
	partial class Lab82
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
			this.answerLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.answerBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// answerLabel
			// 
			this.answerLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.answerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.answerLabel.ForeColor = System.Drawing.Color.Black;
			this.answerLabel.Location = new System.Drawing.Point(0, 70);
			this.answerLabel.Name = "answerLabel";
			this.answerLabel.Size = new System.Drawing.Size(211, 49);
			this.answerLabel.TabIndex = 5;
			this.answerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(211, 26);
			this.label1.TabIndex = 4;
			this.label1.Text = "Color?";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// answerBtn
			// 
			this.answerBtn.BackColor = System.Drawing.Color.Honeydew;
			this.answerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.answerBtn.Location = new System.Drawing.Point(64, 38);
			this.answerBtn.Name = "answerBtn";
			this.answerBtn.Size = new System.Drawing.Size(82, 30);
			this.answerBtn.TabIndex = 3;
			this.answerBtn.Text = "Color";
			this.answerBtn.UseVisualStyleBackColor = false;
			this.answerBtn.Click += new System.EventHandler(this.answerBtn_Click);
			// 
			// Lab82
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(211, 119);
			this.Controls.Add(this.answerLabel);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.answerBtn);
			this.Name = "Lab82";
			this.Text = "Lab8";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label answerLabel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button answerBtn;
	}
}