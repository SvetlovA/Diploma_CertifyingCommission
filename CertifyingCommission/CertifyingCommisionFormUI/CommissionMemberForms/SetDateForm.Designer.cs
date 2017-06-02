namespace CertifyingCommisionFormUI.CommissionMemberForms
{
	partial class SetDateForm
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
			this.labelSelectDate = new System.Windows.Forms.Label();
			this.monthCalendar = new System.Windows.Forms.MonthCalendar();
			this.buttonSelect = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelSelectDate
			// 
			this.labelSelectDate.AutoSize = true;
			this.labelSelectDate.Location = new System.Drawing.Point(13, 13);
			this.labelSelectDate.Name = "labelSelectDate";
			this.labelSelectDate.Size = new System.Drawing.Size(119, 13);
			this.labelSelectDate.TabIndex = 0;
			this.labelSelectDate.Text = "Select date for meeting:";
			// 
			// monthCalendar
			// 
			this.monthCalendar.Location = new System.Drawing.Point(61, 35);
			this.monthCalendar.MaxSelectionCount = 1;
			this.monthCalendar.MinDate = new System.DateTime(2017, 6, 2, 0, 0, 0, 0);
			this.monthCalendar.Name = "monthCalendar";
			this.monthCalendar.TabIndex = 2;
			// 
			// buttonSelect
			// 
			this.buttonSelect.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonSelect.Location = new System.Drawing.Point(181, 226);
			this.buttonSelect.Name = "buttonSelect";
			this.buttonSelect.Size = new System.Drawing.Size(75, 23);
			this.buttonSelect.TabIndex = 3;
			this.buttonSelect.Text = "Select";
			this.buttonSelect.UseVisualStyleBackColor = true;
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(262, 226);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 4;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// SetDateForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(349, 261);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonSelect);
			this.Controls.Add(this.monthCalendar);
			this.Controls.Add(this.labelSelectDate);
			this.Name = "SetDateForm";
			this.Text = "Set Date";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelSelectDate;
		private System.Windows.Forms.MonthCalendar monthCalendar;
		private System.Windows.Forms.Button buttonSelect;
		private System.Windows.Forms.Button buttonCancel;
	}
}