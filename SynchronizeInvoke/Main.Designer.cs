namespace SynchronizeInvoke
{
	partial class Main
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
			this.Progress = new System.Windows.Forms.ProgressBar();
			this.Test = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Progress
			// 
			this.Progress.Location = new System.Drawing.Point(118, 12);
			this.Progress.Name = "Progress";
			this.Progress.Size = new System.Drawing.Size(187, 23);
			this.Progress.TabIndex = 0;
			// 
			// Test
			// 
			this.Test.Location = new System.Drawing.Point(24, 12);
			this.Test.Name = "Test";
			this.Test.Size = new System.Drawing.Size(75, 23);
			this.Test.TabIndex = 1;
			this.Test.Text = "Test";
			this.Test.UseVisualStyleBackColor = true;
			this.Test.Click += new System.EventHandler(this.Test_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(326, 45);
			this.Controls.Add(this.Test);
			this.Controls.Add(this.Progress);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Main";
			this.Text = "SynchronizeInvoke Demo";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ProgressBar Progress;
		private System.Windows.Forms.Button Test;
	}
}

