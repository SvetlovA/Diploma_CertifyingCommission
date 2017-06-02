namespace CertifyingCommisionFormUI.CommissionMemberForms
{
	partial class ConfirmedMeetingsForm
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
			this.groupBoxMeetings = new System.Windows.Forms.GroupBox();
			this.dataGridViewMeetings = new System.Windows.Forms.DataGridView();
			this.groupBoxActions = new System.Windows.Forms.GroupBox();
			this.buttonSetDate = new System.Windows.Forms.Button();
			this.groupBoxMeetings.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewMeetings)).BeginInit();
			this.groupBoxActions.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBoxMeetings
			// 
			this.groupBoxMeetings.Controls.Add(this.dataGridViewMeetings);
			this.groupBoxMeetings.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBoxMeetings.Location = new System.Drawing.Point(0, 0);
			this.groupBoxMeetings.Name = "groupBoxMeetings";
			this.groupBoxMeetings.Size = new System.Drawing.Size(717, 246);
			this.groupBoxMeetings.TabIndex = 0;
			this.groupBoxMeetings.TabStop = false;
			this.groupBoxMeetings.Text = "Meetings";
			// 
			// dataGridViewMeetings
			// 
			this.dataGridViewMeetings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewMeetings.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewMeetings.Location = new System.Drawing.Point(3, 16);
			this.dataGridViewMeetings.Name = "dataGridViewMeetings";
			this.dataGridViewMeetings.Size = new System.Drawing.Size(711, 227);
			this.dataGridViewMeetings.TabIndex = 0;
			// 
			// groupBoxActions
			// 
			this.groupBoxActions.Controls.Add(this.buttonSetDate);
			this.groupBoxActions.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupBoxActions.Location = new System.Drawing.Point(0, 252);
			this.groupBoxActions.Name = "groupBoxActions";
			this.groupBoxActions.Size = new System.Drawing.Size(717, 47);
			this.groupBoxActions.TabIndex = 1;
			this.groupBoxActions.TabStop = false;
			this.groupBoxActions.Text = "Actions";
			// 
			// buttonSetDate
			// 
			this.buttonSetDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonSetDate.Location = new System.Drawing.Point(13, 18);
			this.buttonSetDate.Name = "buttonSetDate";
			this.buttonSetDate.Size = new System.Drawing.Size(75, 23);
			this.buttonSetDate.TabIndex = 0;
			this.buttonSetDate.Text = "Set date";
			this.buttonSetDate.UseVisualStyleBackColor = true;
			this.buttonSetDate.Click += new System.EventHandler(this.buttonSetDate_Click);
			// 
			// ConfirmedMeetingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(717, 299);
			this.Controls.Add(this.groupBoxActions);
			this.Controls.Add(this.groupBoxMeetings);
			this.Name = "ConfirmedMeetingsForm";
			this.Text = "Submited Meetings";
			this.groupBoxMeetings.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewMeetings)).EndInit();
			this.groupBoxActions.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBoxMeetings;
		private System.Windows.Forms.DataGridView dataGridViewMeetings;
		private System.Windows.Forms.GroupBox groupBoxActions;
		private System.Windows.Forms.Button buttonSetDate;
	}
}