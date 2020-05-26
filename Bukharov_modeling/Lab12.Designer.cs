namespace Bukharov_modeling
{
	partial class Lab12
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
			this.resultList = new System.Windows.Forms.ListView();
			this.teamColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.winColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.goalColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.resultBtn = new System.Windows.Forms.Button();
			this.allResultBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// resultList
			// 
			this.resultList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.teamColumn,
            this.winColumn,
            this.goalColumn});
			this.resultList.HideSelection = false;
			this.resultList.Location = new System.Drawing.Point(13, 13);
			this.resultList.Name = "resultList";
			this.resultList.Size = new System.Drawing.Size(203, 222);
			this.resultList.TabIndex = 0;
			this.resultList.UseCompatibleStateImageBehavior = false;
			this.resultList.View = System.Windows.Forms.View.Details;
			// 
			// teamColumn
			// 
			this.teamColumn.Text = "Team";
			this.teamColumn.Width = 95;
			// 
			// winColumn
			// 
			this.winColumn.Text = "Win";
			this.winColumn.Width = 53;
			// 
			// goalColumn
			// 
			this.goalColumn.Text = "Goal";
			this.goalColumn.Width = 51;
			// 
			// resultBtn
			// 
			this.resultBtn.Location = new System.Drawing.Point(12, 241);
			this.resultBtn.Name = "resultBtn";
			this.resultBtn.Size = new System.Drawing.Size(75, 23);
			this.resultBtn.TabIndex = 1;
			this.resultBtn.Text = "Game result";
			this.resultBtn.UseVisualStyleBackColor = true;
			this.resultBtn.Click += new System.EventHandler(this.resultBtn_Click);
			// 
			// allResultBtn
			// 
			this.allResultBtn.Location = new System.Drawing.Point(141, 241);
			this.allResultBtn.Name = "allResultBtn";
			this.allResultBtn.Size = new System.Drawing.Size(75, 23);
			this.allResultBtn.TabIndex = 2;
			this.allResultBtn.Text = "All result";
			this.allResultBtn.UseVisualStyleBackColor = true;
			this.allResultBtn.Click += new System.EventHandler(this.button1_Click);
			// 
			// Lab12
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(228, 274);
			this.Controls.Add(this.allResultBtn);
			this.Controls.Add(this.resultBtn);
			this.Controls.Add(this.resultList);
			this.Name = "Lab12";
			this.Text = "Lab12";
			this.Load += new System.EventHandler(this.Lab12_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView resultList;
		private System.Windows.Forms.ColumnHeader teamColumn;
		private System.Windows.Forms.ColumnHeader winColumn;
		private System.Windows.Forms.ColumnHeader goalColumn;
		private System.Windows.Forms.Button resultBtn;
		private System.Windows.Forms.Button allResultBtn;
	}
}