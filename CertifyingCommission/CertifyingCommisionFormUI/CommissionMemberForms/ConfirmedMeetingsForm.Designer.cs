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
			this.groupBoxFinder = new System.Windows.Forms.GroupBox();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonFind = new System.Windows.Forms.Button();
			this.dateTimePickerToDate = new System.Windows.Forms.DateTimePicker();
			this.labelDash = new System.Windows.Forms.Label();
			this.labelFinder = new System.Windows.Forms.Label();
			this.dateTimePickerFromDate = new System.Windows.Forms.DateTimePicker();
			this.groupBoxMeetings.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewMeetings)).BeginInit();
			this.groupBoxActions.SuspendLayout();
			this.groupBoxFinder.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBoxMeetings
			// 
			this.groupBoxMeetings.Controls.Add(this.dataGridViewMeetings);
			this.groupBoxMeetings.Location = new System.Drawing.Point(0, 64);
			this.groupBoxMeetings.Name = "groupBoxMeetings";
			this.groupBoxMeetings.Size = new System.Drawing.Size(717, 235);
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
			this.dataGridViewMeetings.Size = new System.Drawing.Size(711, 216);
			this.dataGridViewMeetings.TabIndex = 0;
			// 
			// groupBoxActions
			// 
			this.groupBoxActions.Controls.Add(this.buttonSetDate);
			this.groupBoxActions.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupBoxActions.Location = new System.Drawing.Point(0, 305);
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
			// groupBoxFinder
			// 
			this.groupBoxFinder.Controls.Add(this.buttonCancel);
			this.groupBoxFinder.Controls.Add(this.buttonFind);
			this.groupBoxFinder.Controls.Add(this.dateTimePickerToDate);
			this.groupBoxFinder.Controls.Add(this.labelDash);
			this.groupBoxFinder.Controls.Add(this.labelFinder);
			this.groupBoxFinder.Controls.Add(this.dateTimePickerFromDate);
			this.groupBoxFinder.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBoxFinder.Location = new System.Drawing.Point(0, 0);
			this.groupBoxFinder.Name = "groupBoxFinder";
			this.groupBoxFinder.Size = new System.Drawing.Size(717, 58);
			this.groupBoxFinder.TabIndex = 3;
			this.groupBoxFinder.TabStop = false;
			this.groupBoxFinder.Text = "Finder";
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(515, 25);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 5;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// buttonFind
			// 
			this.buttonFind.Location = new System.Drawing.Point(434, 26);
			this.buttonFind.Name = "buttonFind";
			this.buttonFind.Size = new System.Drawing.Size(75, 23);
			this.buttonFind.TabIndex = 4;
			this.buttonFind.Text = "Find";
			this.buttonFind.UseVisualStyleBackColor = true;
			this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
			// 
			// dateTimePickerToDate
			// 
			this.dateTimePickerToDate.Location = new System.Drawing.Point(228, 29);
			this.dateTimePickerToDate.Name = "dateTimePickerToDate";
			this.dateTimePickerToDate.Size = new System.Drawing.Size(200, 20);
			this.dateTimePickerToDate.TabIndex = 3;
			// 
			// labelDash
			// 
			this.labelDash.AutoSize = true;
			this.labelDash.Location = new System.Drawing.Point(212, 35);
			this.labelDash.Name = "labelDash";
			this.labelDash.Size = new System.Drawing.Size(10, 13);
			this.labelDash.TabIndex = 2;
			this.labelDash.Text = "-";
			// 
			// labelFinder
			// 
			this.labelFinder.AutoSize = true;
			this.labelFinder.Location = new System.Drawing.Point(13, 13);
			this.labelFinder.Name = "labelFinder";
			this.labelFinder.Size = new System.Drawing.Size(182, 13);
			this.labelFinder.TabIndex = 1;
			this.labelFinder.Text = "Select time interwal of meetings date:";
			// 
			// dateTimePickerFromDate
			// 
			this.dateTimePickerFromDate.Location = new System.Drawing.Point(6, 29);
			this.dateTimePickerFromDate.Name = "dateTimePickerFromDate";
			this.dateTimePickerFromDate.Size = new System.Drawing.Size(200, 20);
			this.dateTimePickerFromDate.TabIndex = 0;
			// 
			// ConfirmedMeetingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(717, 352);
			this.Controls.Add(this.groupBoxFinder);
			this.Controls.Add(this.groupBoxActions);
			this.Controls.Add(this.groupBoxMeetings);
			this.Name = "ConfirmedMeetingsForm";
			this.Text = "Submited Meetings";
			this.groupBoxMeetings.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewMeetings)).EndInit();
			this.groupBoxActions.ResumeLayout(false);
			this.groupBoxFinder.ResumeLayout(false);
			this.groupBoxFinder.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBoxMeetings;
		private System.Windows.Forms.DataGridView dataGridViewMeetings;
		private System.Windows.Forms.GroupBox groupBoxActions;
		private System.Windows.Forms.Button buttonSetDate;
		private System.Windows.Forms.GroupBox groupBoxFinder;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonFind;
		private System.Windows.Forms.DateTimePicker dateTimePickerToDate;
		private System.Windows.Forms.Label labelDash;
		private System.Windows.Forms.Label labelFinder;
		private System.Windows.Forms.DateTimePicker dateTimePickerFromDate;
	}
}