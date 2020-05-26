namespace Bukharov_modeling
{
	partial class Lab10
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
			this.playBtn = new System.Windows.Forms.Button();
			this.playerScore = new System.Windows.Forms.Label();
			this.cheaterScore = new System.Windows.Forms.Label();
			this.result = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// playBtn
			// 
			this.playBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.playBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.playBtn.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.playBtn.Location = new System.Drawing.Point(0, 256);
			this.playBtn.Name = "playBtn";
			this.playBtn.Size = new System.Drawing.Size(482, 49);
			this.playBtn.TabIndex = 0;
			this.playBtn.Text = "Play";
			this.playBtn.UseVisualStyleBackColor = true;
			this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
			// 
			// playerScore
			// 
			this.playerScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.playerScore.Dock = System.Windows.Forms.DockStyle.Left;
			this.playerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.playerScore.ForeColor = System.Drawing.Color.DarkGreen;
			this.playerScore.Location = new System.Drawing.Point(0, 0);
			this.playerScore.Name = "playerScore";
			this.playerScore.Size = new System.Drawing.Size(159, 256);
			this.playerScore.TabIndex = 1;
			this.playerScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cheaterScore
			// 
			this.cheaterScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cheaterScore.Dock = System.Windows.Forms.DockStyle.Right;
			this.cheaterScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cheaterScore.ForeColor = System.Drawing.Color.Maroon;
			this.cheaterScore.Location = new System.Drawing.Point(324, 0);
			this.cheaterScore.Name = "cheaterScore";
			this.cheaterScore.Size = new System.Drawing.Size(158, 256);
			this.cheaterScore.TabIndex = 2;
			this.cheaterScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// result
			// 
			this.result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.result.Dock = System.Windows.Forms.DockStyle.Fill;
			this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.result.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.result.Location = new System.Drawing.Point(159, 0);
			this.result.Name = "result";
			this.result.Size = new System.Drawing.Size(165, 256);
			this.result.TabIndex = 3;
			this.result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Lab10
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(482, 305);
			this.Controls.Add(this.result);
			this.Controls.Add(this.cheaterScore);
			this.Controls.Add(this.playerScore);
			this.Controls.Add(this.playBtn);
			this.Name = "Lab10";
			this.Text = "Lab10";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button playBtn;
		private System.Windows.Forms.Label playerScore;
		private System.Windows.Forms.Label cheaterScore;
		private System.Windows.Forms.Label result;
	}
}