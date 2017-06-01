namespace CertifyingCommisionFormUI.SecretaryForms
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
			this.groupBoxMeetings = new System.Windows.Forms.GroupBox();
			this.dataGridViewMeetings = new System.Windows.Forms.DataGridView();
			this.groupBoxActions = new System.Windows.Forms.GroupBox();
			this.buttonReject = new System.Windows.Forms.Button();
			this.buttonConfirm = new System.Windows.Forms.Button();
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
			this.groupBoxMeetings.Size = new System.Drawing.Size(877, 346);
			this.groupBoxMeetings.TabIndex = 0;
			this.groupBoxMeetings.TabStop = false;
			this.groupBoxMeetings.Text = "Meetings";
			// 
			// dataGridViewMeetings
			// 
			this.dataGridViewMeetings.AllowUserToAddRows = false;
			this.dataGridViewMeetings.AllowUserToDeleteRows = false;
			this.dataGridViewMeetings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewMeetings.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewMeetings.Location = new System.Drawing.Point(3, 16);
			this.dataGridViewMeetings.Name = "dataGridViewMeetings";
			this.dataGridViewMeetings.ReadOnly = true;
			this.dataGridViewMeetings.Size = new System.Drawing.Size(871, 327);
			this.dataGridViewMeetings.TabIndex = 0;
			// 
			// groupBoxActions
			// 
			this.groupBoxActions.Controls.Add(this.buttonReject);
			this.groupBoxActions.Controls.Add(this.buttonConfirm);
			this.groupBoxActions.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupBoxActions.Location = new System.Drawing.Point(0, 352);
			this.groupBoxActions.Name = "groupBoxActions";
			this.groupBoxActions.Size = new System.Drawing.Size(877, 48);
			this.groupBoxActions.TabIndex = 1;
			this.groupBoxActions.TabStop = false;
			this.groupBoxActions.Text = "Actions";
			// 
			// buttonReject
			// 
			this.buttonReject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonReject.Location = new System.Drawing.Point(90, 13);
			this.buttonReject.Name = "buttonReject";
			this.buttonReject.Size = new System.Drawing.Size(75, 23);
			this.buttonReject.TabIndex = 1;
			this.buttonReject.Text = "Reject";
			this.buttonReject.UseVisualStyleBackColor = true;
			this.buttonReject.Click += new System.EventHandler(this.buttonReject_Click);
			// 
			// buttonConfirm
			// 
			this.buttonConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonConfirm.Location = new System.Drawing.Point(12, 13);
			this.buttonConfirm.Name = "buttonConfirm";
			this.buttonConfirm.Size = new System.Drawing.Size(75, 23);
			this.buttonConfirm.TabIndex = 0;
			this.buttonConfirm.Text = "Confirm";
			this.buttonConfirm.UseVisualStyleBackColor = true;
			this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
			// 
			// MeetingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(877, 400);
			this.Controls.Add(this.groupBoxActions);
			this.Controls.Add(this.groupBoxMeetings);
			this.Name = "MeetingsForm";
			this.Text = "Meetings";
			this.groupBoxMeetings.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewMeetings)).EndInit();
			this.groupBoxActions.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBoxMeetings;
		private System.Windows.Forms.DataGridView dataGridViewMeetings;
		private System.Windows.Forms.GroupBox groupBoxActions;
		private System.Windows.Forms.Button buttonReject;
		private System.Windows.Forms.Button buttonConfirm;
	}
}