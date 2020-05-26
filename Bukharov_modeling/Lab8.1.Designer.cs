namespace Bukharov_modeling
{
	partial class Lab81
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.answerBtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.answerLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// answerBtn
			// 
			this.answerBtn.BackColor = System.Drawing.Color.Honeydew;
			this.answerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.answerBtn.Location = new System.Drawing.Point(64, 38);
			this.answerBtn.Name = "answerBtn";
			this.answerBtn.Size = new System.Drawing.Size(82, 30);
			this.answerBtn.TabIndex = 0;
			this.answerBtn.Text = "Answer";
			this.answerBtn.UseVisualStyleBackColor = false;
			this.answerBtn.Click += new System.EventHandler(this.answerBtn_Click);
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(213, 26);
			this.label1.TabIndex = 1;
			this.label1.Text = "To be or Not to be?";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// answerLabel
			// 
			this.answerLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.answerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.answerLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.answerLabel.Location = new System.Drawing.Point(0, 71);
			this.answerLabel.Name = "answerLabel";
			this.answerLabel.Size = new System.Drawing.Size(213, 49);
			this.answerLabel.TabIndex = 2;
			this.answerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(213, 120);
			this.Controls.Add(this.answerLabel);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.answerBtn);
			this.Name = "Form1";
			this.Text = "Lab 8.1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button answerBtn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label answerLabel;
	}
}

