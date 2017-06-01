namespace CertifyingCommisionFormUI.TeacherForms
{
	partial class MeetingsForm
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
			this.dataGridViewMeetings = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewMeetings)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewMeetings
			// 
			this.dataGridViewMeetings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewMeetings.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewMeetings.Location = new System.Drawing.Point(0, 0);
			this.dataGridViewMeetings.Name = "dataGridViewMeetings";
			this.dataGridViewMeetings.Size = new System.Drawing.Size(687, 261);
			this.dataGridViewMeetings.TabIndex = 0;
			// 
			// MeetingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(687, 261);
			this.Controls.Add(this.dataGridViewMeetings);
			this.Name = "MeetingsForm";
			this.Text = "Meetings";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewMeetings)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridViewMeetings;
	}
}