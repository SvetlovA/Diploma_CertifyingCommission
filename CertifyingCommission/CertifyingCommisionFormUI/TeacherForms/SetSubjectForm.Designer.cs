namespace CertifyingCommisionFormUI.TeacherForms
{
	partial class SetSubjectForm
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
			this.labelSelectSubject = new System.Windows.Forms.Label();
			this.comboBoxSubjects = new System.Windows.Forms.ComboBox();
			this.buttonSelect = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelSelectSubject
			// 
			this.labelSelectSubject.AutoSize = true;
			this.labelSelectSubject.Location = new System.Drawing.Point(13, 13);
			this.labelSelectSubject.Name = "labelSelectSubject";
			this.labelSelectSubject.Size = new System.Drawing.Size(77, 13);
			this.labelSelectSubject.TabIndex = 0;
			this.labelSelectSubject.Text = "Select subject:";
			// 
			// comboBoxSubjects
			// 
			this.comboBoxSubjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxSubjects.FormattingEnabled = true;
			this.comboBoxSubjects.Location = new System.Drawing.Point(96, 10);
			this.comboBoxSubjects.Name = "comboBoxSubjects";
			this.comboBoxSubjects.Size = new System.Drawing.Size(176, 21);
			this.comboBoxSubjects.TabIndex = 1;
			// 
			// buttonSelect
			// 
			this.buttonSelect.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonSelect.Location = new System.Drawing.Point(116, 52);
			this.buttonSelect.Name = "buttonSelect";
			this.buttonSelect.Size = new System.Drawing.Size(75, 23);
			this.buttonSelect.TabIndex = 2;
			this.buttonSelect.Text = "Select";
			this.buttonSelect.UseVisualStyleBackColor = true;
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(197, 52);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 3;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// SetSubjectForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 87);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonSelect);
			this.Controls.Add(this.comboBoxSubjects);
			this.Controls.Add(this.labelSelectSubject);
			this.Name = "SetSubjectForm";
			this.Text = "Set Subject";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelSelectSubject;
		private System.Windows.Forms.ComboBox comboBoxSubjects;
		private System.Windows.Forms.Button buttonSelect;
		private System.Windows.Forms.Button buttonCancel;
	}
}